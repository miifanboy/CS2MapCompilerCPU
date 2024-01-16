using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2MapCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cs2dir;
        string resourcecompiler;
        string addonname;
        string mapname;
        string mappath;
        string outputpath;
        string arg;
        static string output;
        Process process;
        private string GetCS2Dir()
        {
            string steamPath = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", "");
            string pathsFile = Path.Combine(steamPath, "steamapps", "libraryfolders.vdf");

            if (!File.Exists(pathsFile))
                return null;

            List<string> libraries = new List<string>();
            libraries.Add(Path.Combine(steamPath));

            var pathVDF = File.ReadAllLines(pathsFile);
            // Okay, this is not a full vdf-parser, but it seems to work pretty much, since the 
            // vdf-grammar is pretty easy. Hopefully it never breaks. I'm too lazy to write a full vdf-parser though. 
            Regex pathRegex = new Regex(@"\""(([^\""]*):\\([^\""]*))\""");
            foreach (var line in pathVDF)
            {
                if (pathRegex.IsMatch(line))
                {
                    string match = pathRegex.Matches(line)[0].Groups[1].Value;

                    // De-Escape vdf. 
                    libraries.Add(match.Replace("\\\\", "\\"));
                }
            }

            foreach (var library in libraries)
            {
                string cs2Path = Path.Combine(library, "steamapps\\common\\Counter-Strike Global Offensive\\game\\bin\\win64");
                if (Directory.Exists(cs2Path))
                {
                    return cs2Path;
                }
            }

            return null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lightmapres.SelectedIndex = 2;
            lightmapquality.SelectedIndex = 1;
            cs2dir = GetCS2Dir();
            CS2Validator();
        }
        void CS2Validator()
        {
            if (File.Exists(Path.Combine(cs2dir ,"cs2.exe")))
            {
                cs2status.Text = "Found";
                cs2status.ForeColor = Color.Green;
                button1.Enabled = true;
                if (File.Exists(Path.Combine(cs2dir ,"resourcecompiler.exe")))
                {
                    wststatus.Text = "Found";
                    wststatus.ForeColor = Color.Green;
                    resourcecompiler = Path.Combine(cs2dir, "resourcecompiler.exe");
                    button1.Enabled = true;
                }
                else
                {
                    wststatus.Text = "Not Found";
                    wststatus.ForeColor = Color.DarkRed;
                    MessageBox.Show("Please Install Workshop Tools!", "CS2 Map Compiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Enabled = false;
                }
            }
            else
            {
                cs2status.Text = "Not Found";
                cs2status.ForeColor = Color.DarkRed;
                wststatus.Text = "Not Found";
                wststatus.ForeColor = Color.DarkRed;
                MessageBox.Show("CS2 Installation Not Found! Please install the game or set the path manually in the options! ", "CS2 Map Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        string ArgumentBuilder()
        {
            List<string> args = new List<string>();
            string argument = "-threads 3 -fshallow -maxtextureres 256 -dxlevel 110 -quiet -unbufferedio -i " + string.Format("\"{0}\"",mappath) + " -noassert ";
            
            if(buildworld.Checked)
            {
                args.Add("-world");
            }
            if(!settlephys.Checked)
            {
                args.Add("-nosettle");
            }
            if (genLightmaps.Checked)
            {
                args.Add("-bakelighting");
                if (cpu.Checked)
                {
                    args.Add("-lightmapcpu");
                }
                args.Add("-lightmapMaxResolution " + lightmapres.Text);
                args.Add("-lightmapDoWeld");
                args.Add("-lightmapVRadQuality " + lightmapquality.SelectedIndex.ToString());
                if(!compression.Checked)
                {
                    args.Add("-lightmapDisableFiltering");
                }
                args.Add("-lightmapLocalCompile");
                
            }
            else if(!genLightmaps.Checked)
            {
                args.Add("-nolightmaps");
            }
            if(buildPhys.Checked)
            {
                args.Add("-phys");
            }
            if (buildVis.Checked)
            {
                args.Add("-vis");
            }
            if (buildNav.Checked)
            {
                args.Add("-nav");
            }
            args.Add("-retail -breakpad -nop4 -outroot ");
            return argument + string.Join(" ",args.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process = new Process();
            var task = new Task(() => ProcessThread());
            if (File.Exists(Path.Combine(outputpath, Path.GetFileNameWithoutExtension(mapname) + ".vpk")))
            {
                var response = MessageBox.Show("Do you want to overwrite the existing map file?", "CS2 Map Compiler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    arg = ArgumentBuilder() + string.Format("\"{0}\"", outputpath);
                    task.Start();
                }
                else
                {
                    MessageBox.Show("Compile Cancelled!", "CS2 Map Compiler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                arg = ArgumentBuilder() + string.Format("\"{0}\"", outputpath);
                task.Start();
            }
        }
        
        private void ProcessThread()
        {
            
            process.StartInfo.FileName = resourcecompiler;
            process.StartInfo.Arguments = arg;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            
            //* Set ONLY ONE handler here.
            
            //* Start process

            process.Start();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(CS2MapCompiler) Compile started! - " + DateTime.Now + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            //* Read one element asynchronously
            //* Read the other one synchronously

            output = process.StandardError.ReadToEnd();
            Console.WriteLine(output);
            
            process.WaitForExit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!process.HasExited)
            {
                process.Kill();
                process.WaitForExit();
                process.Dispose();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(CS2MapCompiler) Compile cancelled! - " + DateTime.Now + "\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(CS2MapCompiler) Compile already exited! - " + DateTime.Now + "\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "cs2.exe |*.exe";
            if(file.ShowDialog() == DialogResult.OK)
            {
                cs2dir = Path.GetDirectoryName(file.FileName);
                CS2Validator();
            }
        }

        private void genLightmaps_CheckedChanged(object sender, EventArgs e)
        {
            if(genLightmaps.Checked == false)
            {
                cpu.Enabled = false;
                lightmapres.Enabled = false;
                lightmapquality.Enabled = false;
                compression.Enabled = false;
            }
            else
            {
                cpu.Enabled = true;
                lightmapres.Enabled = true;
                lightmapquality.Enabled = true;
                compression.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Directory.GetParent(cs2dir).Parent.Parent.FullName + "\\content\\csgo_addons\\";
            file.Filter = "Hammer Map File |*.vmap";
            if (file.ShowDialog() == DialogResult.OK)
            {
                mappath = file.FileName;
                mapname = Path.GetFileName(file.FileName);
                addonname = Directory.GetParent(file.FileName).Parent.Name;
                outputpath = Directory.GetParent(cs2dir).Parent.FullName;
                outputdir.Text = outputpath;
                button5.Enabled = true;
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dummyFileName = "Select Here";
            SaveFileDialog file = new SaveFileDialog();
            file.InitialDirectory = Directory.GetParent(cs2dir).Parent.FullName + "\\csgo_addons\\" + addonname + "\\maps\\";
            file.FileName = dummyFileName;
            file.Filter = "Directory | directory";
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                outputpath = Path.GetDirectoryName(file.FileName);
                outputdir.Text = outputpath;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine(ArgumentBuilder() + string.Format("\"{0}\"", outputpath));
        }
    }
}


namespace CS2MapCompiler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cs2status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wststatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buildworld = new System.Windows.Forms.CheckBox();
            this.settlephys = new System.Windows.Forms.CheckBox();
            this.genLightmaps = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lightmapres = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lightmapquality = new System.Windows.Forms.ComboBox();
            this.compression = new System.Windows.Forms.CheckBox();
            this.noiseremoval = new System.Windows.Forms.CheckBox();
            this.buildPhys = new System.Windows.Forms.CheckBox();
            this.buildVis = new System.Windows.Forms.CheckBox();
            this.buildNav = new System.Windows.Forms.CheckBox();
            this.cpu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.outputdir = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CS2";
            // 
            // cs2status
            // 
            this.cs2status.AutoSize = true;
            this.cs2status.ForeColor = System.Drawing.Color.DarkRed;
            this.cs2status.Location = new System.Drawing.Point(142, 17);
            this.cs2status.Name = "cs2status";
            this.cs2status.Size = new System.Drawing.Size(57, 13);
            this.cs2status.TabIndex = 4;
            this.cs2status.Text = "Not Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Workshop Tools";
            // 
            // wststatus
            // 
            this.wststatus.AutoSize = true;
            this.wststatus.ForeColor = System.Drawing.Color.DarkRed;
            this.wststatus.Location = new System.Drawing.Point(307, 17);
            this.wststatus.Name = "wststatus";
            this.wststatus.Size = new System.Drawing.Size(57, 13);
            this.wststatus.TabIndex = 6;
            this.wststatus.Text = "Not Found";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "Custom Path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buildworld
            // 
            this.buildworld.AutoSize = true;
            this.buildworld.Checked = true;
            this.buildworld.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildworld.Location = new System.Drawing.Point(13, 90);
            this.buildworld.Name = "buildworld";
            this.buildworld.Size = new System.Drawing.Size(80, 17);
            this.buildworld.TabIndex = 8;
            this.buildworld.Text = "Build World";
            this.buildworld.UseVisualStyleBackColor = true;
            // 
            // settlephys
            // 
            this.settlephys.AutoSize = true;
            this.settlephys.Checked = true;
            this.settlephys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settlephys.Location = new System.Drawing.Point(12, 129);
            this.settlephys.Name = "settlephys";
            this.settlephys.Size = new System.Drawing.Size(147, 17);
            this.settlephys.TabIndex = 9;
            this.settlephys.Text = "Pre-Settle physics objects";
            this.settlephys.UseVisualStyleBackColor = true;
            // 
            // genLightmaps
            // 
            this.genLightmaps.AutoSize = true;
            this.genLightmaps.Checked = true;
            this.genLightmaps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genLightmaps.Location = new System.Drawing.Point(12, 170);
            this.genLightmaps.Name = "genLightmaps";
            this.genLightmaps.Size = new System.Drawing.Size(121, 17);
            this.genLightmaps.TabIndex = 10;
            this.genLightmaps.Text = "Generate Lightmaps";
            this.genLightmaps.UseVisualStyleBackColor = true;
            this.genLightmaps.CheckedChanged += new System.EventHandler(this.genLightmaps_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resolution:";
            // 
            // lightmapres
            // 
            this.lightmapres.FormattingEnabled = true;
            this.lightmapres.Items.AddRange(new object[] {
            "8192",
            "4096",
            "2048",
            "1024",
            "512"});
            this.lightmapres.Location = new System.Drawing.Point(78, 199);
            this.lightmapres.Name = "lightmapres";
            this.lightmapres.Size = new System.Drawing.Size(55, 21);
            this.lightmapres.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quality:";
            // 
            // lightmapquality
            // 
            this.lightmapquality.FormattingEnabled = true;
            this.lightmapquality.Items.AddRange(new object[] {
            "Fast",
            "Standard",
            "Final"});
            this.lightmapquality.Location = new System.Drawing.Point(190, 199);
            this.lightmapquality.Name = "lightmapquality";
            this.lightmapquality.Size = new System.Drawing.Size(82, 21);
            this.lightmapquality.TabIndex = 14;
            // 
            // compression
            // 
            this.compression.AutoSize = true;
            this.compression.Checked = true;
            this.compression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compression.Location = new System.Drawing.Point(288, 201);
            this.compression.Name = "compression";
            this.compression.Size = new System.Drawing.Size(86, 17);
            this.compression.TabIndex = 15;
            this.compression.Text = "Compression";
            this.compression.UseVisualStyleBackColor = true;
            // 
            // noiseremoval
            // 
            this.noiseremoval.AutoSize = true;
            this.noiseremoval.Checked = true;
            this.noiseremoval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noiseremoval.Location = new System.Drawing.Point(13, 237);
            this.noiseremoval.Name = "noiseremoval";
            this.noiseremoval.Size = new System.Drawing.Size(98, 17);
            this.noiseremoval.TabIndex = 16;
            this.noiseremoval.Text = "Noise Removal";
            this.noiseremoval.UseVisualStyleBackColor = true;
            // 
            // buildPhys
            // 
            this.buildPhys.AutoSize = true;
            this.buildPhys.Checked = true;
            this.buildPhys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildPhys.Location = new System.Drawing.Point(12, 281);
            this.buildPhys.Name = "buildPhys";
            this.buildPhys.Size = new System.Drawing.Size(88, 17);
            this.buildPhys.TabIndex = 17;
            this.buildPhys.Text = "Build Physics";
            this.buildPhys.UseVisualStyleBackColor = true;
            // 
            // buildVis
            // 
            this.buildVis.AutoSize = true;
            this.buildVis.Checked = true;
            this.buildVis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildVis.Location = new System.Drawing.Point(12, 317);
            this.buildVis.Name = "buildVis";
            this.buildVis.Size = new System.Drawing.Size(66, 17);
            this.buildVis.TabIndex = 18;
            this.buildVis.Text = "Build Vis";
            this.buildVis.UseVisualStyleBackColor = true;
            // 
            // buildNav
            // 
            this.buildNav.AutoSize = true;
            this.buildNav.Checked = true;
            this.buildNav.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildNav.Location = new System.Drawing.Point(12, 353);
            this.buildNav.Name = "buildNav";
            this.buildNav.Size = new System.Drawing.Size(72, 17);
            this.buildNav.TabIndex = 19;
            this.buildNav.Text = "Build Nav";
            this.buildNav.UseVisualStyleBackColor = true;
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Checked = true;
            this.cpu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpu.Location = new System.Drawing.Point(139, 170);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(70, 17);
            this.cpu.TabIndex = 20;
            this.cpu.Text = "Use CPU";
            this.cpu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(206, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Use This If You Don\'t Have a RTX or RDNA 2 Card ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 21);
            this.button4.TabIndex = 22;
            this.button4.Text = "Open .vmap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Output:";
            // 
            // outputdir
            // 
            this.outputdir.AutoSize = true;
            this.outputdir.Location = new System.Drawing.Point(57, 383);
            this.outputdir.MaximumSize = new System.Drawing.Size(450, 0);
            this.outputdir.Name = "outputdir";
            this.outputdir.Size = new System.Drawing.Size(27, 13);
            this.outputdir.TabIndex = 24;
            this.outputdir.Text = "N/A";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(288, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 21);
            this.button5.TabIndex = 25;
            this.button5.Text = "Change Output";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 427);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.outputdir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.buildNav);
            this.Controls.Add(this.buildVis);
            this.Controls.Add(this.buildPhys);
            this.Controls.Add(this.noiseremoval);
            this.Controls.Add(this.compression);
            this.Controls.Add(this.lightmapquality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lightmapres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genLightmaps);
            this.Controls.Add(this.settlephys);
            this.Controls.Add(this.buildworld);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.wststatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cs2status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CS2 Map Compiler with CPU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cs2status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wststatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox buildworld;
        private System.Windows.Forms.CheckBox settlephys;
        private System.Windows.Forms.CheckBox genLightmaps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lightmapres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lightmapquality;
        private System.Windows.Forms.CheckBox compression;
        private System.Windows.Forms.CheckBox noiseremoval;
        private System.Windows.Forms.CheckBox buildPhys;
        private System.Windows.Forms.CheckBox buildVis;
        private System.Windows.Forms.CheckBox buildNav;
        private System.Windows.Forms.CheckBox cpu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outputdir;
        private System.Windows.Forms.Button button5;
    }
}


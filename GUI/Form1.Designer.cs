namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfSongs = new System.Windows.Forms.TextBox();
            this.Randomize = new System.Windows.Forms.Button();
            this.GenXml = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MusicDirectory = new System.Windows.Forms.TextBox();
            this.FileExtensions = new System.Windows.Forms.TextBox();
            this.MusicDestination = new System.Windows.Forms.TextBox();
            this.ArchivePath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.SongArtist = new System.Windows.Forms.TextBox();
            this.SongAlbum = new System.Windows.Forms.TextBox();
            this.SongTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.LblBitrate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblPath = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Music Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Extensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Archive Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Music Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Songs";
            // 
            // NumberOfSongs
            // 
            this.NumberOfSongs.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI.Properties.Settings.Default, "NumberOfSongs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NumberOfSongs.Location = new System.Drawing.Point(101, 109);
            this.NumberOfSongs.Name = "NumberOfSongs";
            this.NumberOfSongs.Size = new System.Drawing.Size(311, 20);
            this.NumberOfSongs.TabIndex = 5;
            this.NumberOfSongs.Text = global::GUI.Properties.Settings.Default.NumberOfSongs;
            this.NumberOfSongs.Leave += new System.EventHandler(this.Format_Text);
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(217, 154);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(195, 23);
            this.Randomize.TabIndex = 13;
            this.Randomize.Text = "Randomize";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // GenXml
            // 
            this.GenXml.Location = new System.Drawing.Point(7, 154);
            this.GenXml.Name = "GenXml";
            this.GenXml.Size = new System.Drawing.Size(204, 23);
            this.GenXml.TabIndex = 14;
            this.GenXml.Text = "Generate Xml";
            this.GenXml.UseVisualStyleBackColor = true;
            this.GenXml.Click += new System.EventHandler(this.GenXml_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 235);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.MusicDirectory);
            this.tabPage1.Controls.Add(this.GenXml);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Randomize);
            this.tabPage1.Controls.Add(this.FileExtensions);
            this.tabPage1.Controls.Add(this.NumberOfSongs);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.MusicDestination);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ArchivePath);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // MusicDirectory
            // 
            this.MusicDirectory.Location = new System.Drawing.Point(101, 6);
            this.MusicDirectory.Name = "MusicDirectory";
            this.MusicDirectory.Size = new System.Drawing.Size(311, 20);
            this.MusicDirectory.TabIndex = 1;
            this.MusicDirectory.Text = global::GUI.Properties.Settings.Default.MusicDirectory;
            this.MusicDirectory.Leave += new System.EventHandler(this.Format_Text);
            // 
            // FileExtensions
            // 
            this.FileExtensions.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI.Properties.Settings.Default, "FileExtensions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FileExtensions.Location = new System.Drawing.Point(101, 32);
            this.FileExtensions.Name = "FileExtensions";
            this.FileExtensions.Size = new System.Drawing.Size(311, 20);
            this.FileExtensions.TabIndex = 2;
            this.FileExtensions.Text = global::GUI.Properties.Settings.Default.FileExtensions;
            this.FileExtensions.Leave += new System.EventHandler(this.Format_Text);
            // 
            // MusicDestination
            // 
            this.MusicDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI.Properties.Settings.Default, "MusicDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MusicDestination.Location = new System.Drawing.Point(101, 83);
            this.MusicDestination.Name = "MusicDestination";
            this.MusicDestination.Size = new System.Drawing.Size(311, 20);
            this.MusicDestination.TabIndex = 4;
            this.MusicDestination.Text = global::GUI.Properties.Settings.Default.MusicDestination;
            this.MusicDestination.Leave += new System.EventHandler(this.Format_Text);
            // 
            // ArchivePath
            // 
            this.ArchivePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI.Properties.Settings.Default, "XmlArchivePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ArchivePath.Location = new System.Drawing.Point(101, 58);
            this.ArchivePath.Name = "ArchivePath";
            this.ArchivePath.Size = new System.Drawing.Size(311, 20);
            this.ArchivePath.TabIndex = 3;
            this.ArchivePath.Text = global::GUI.Properties.Settings.Default.XmlArchivePath;
            this.ArchivePath.Leave += new System.EventHandler(this.UpdateBasePath);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LblPath);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.LblBitrate);
            this.tabPage2.Controls.Add(this.LblDuration);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.SongArtist);
            this.tabPage2.Controls.Add(this.SongAlbum);
            this.tabPage2.Controls.Add(this.SongTitle);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tags";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Load Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SongArtist
            // 
            this.SongArtist.Location = new System.Drawing.Point(50, 82);
            this.SongArtist.Name = "SongArtist";
            this.SongArtist.Size = new System.Drawing.Size(100, 20);
            this.SongArtist.TabIndex = 6;
            // 
            // SongAlbum
            // 
            this.SongAlbum.Location = new System.Drawing.Point(50, 57);
            this.SongAlbum.Name = "SongAlbum";
            this.SongAlbum.Size = new System.Drawing.Size(100, 20);
            this.SongAlbum.TabIndex = 5;
            // 
            // SongTitle
            // 
            this.SongTitle.Location = new System.Drawing.Point(50, 28);
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.Size = new System.Drawing.Size(100, 20);
            this.SongTitle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Artist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Album";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Duration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "BitRate";
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Location = new System.Drawing.Point(68, 133);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(64, 13);
            this.LblDuration.TabIndex = 10;
            this.LblDuration.Text = "Lbl Duration";
            // 
            // LblBitrate
            // 
            this.LblBitrate.AutoSize = true;
            this.LblBitrate.Location = new System.Drawing.Point(68, 146);
            this.LblBitrate.Name = "LblBitrate";
            this.LblBitrate.Size = new System.Drawing.Size(54, 13);
            this.LblBitrate.TabIndex = 11;
            this.LblBitrate.Text = "Lbl Bitrate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Path";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(71, 190);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(46, 13);
            this.LblPath.TabIndex = 13;
            this.LblPath.Text = "Lbl Path";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(435, 238);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Music GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MusicDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileExtensions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ArchivePath;
        private System.Windows.Forms.TextBox MusicDestination;
        private System.Windows.Forms.TextBox NumberOfSongs;
        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.Button GenXml;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SongArtist;
        private System.Windows.Forms.TextBox SongAlbum;
        private System.Windows.Forms.TextBox SongTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblBitrate;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}


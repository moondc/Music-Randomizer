using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Framework;
using System.Configuration;
using System.Reflection;
using System.Xml;
using System.IO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateBasePath();
            //LoadFields();
        }

        // Creates the Xml in the form I want it to and places it in the archive path
        private void GenXml_Click(object sender, EventArgs e)
        {
            Pathing.CreateBasicStructure();
            string music_dir = MusicDirectory.Text;
            string[] file_exts = FileExtensions.Text.Split(',');
            string song_xml_path = ArchivePath.Text;
            List<String> songs = FileListGenerator.Generate(music_dir, file_exts);
            XmlMaker.CreateXmlFromSongs(songs, music_dir, song_xml_path);
        }

        private void LoadFields()
        {
            var controls = ((Control)this).Controls;
            foreach (Control con in controls)
            {
                foreach (Control cont in con.Controls)
                {
                    if (cont.GetType() == typeof(TextBox))
                    {
                        foreach (System.Configuration.SettingsPropertyValue str in Properties.Settings.Default.PropertyValues)
                        {
                            if (cont.Name == str.Name)
                            {
                                cont.Text = str.PropertyValue.ToString();
                            }
                        }
                    }
                }
            }
        }

        // Runs after you leave a textbox to do some custom formatting
        private void Format_Text(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            string text = box.Text;
            if (text.Contains(","))
            {
                // Nothing
            }
            else
            {
                try
                {
                    Convert.ToInt32(text);
                }
                catch (Exception)
                {
                    box.Text = box.Text.EndsWith(@"\") ? box.Text : box.Text + @"\";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var controls = ((Control)this).Controls;
            foreach (Control con in controls)
            {
                if (con.GetType() == typeof(TextBox))
                {
                    foreach (System.Configuration.SettingsPropertyValue str in Properties.Settings.Default.PropertyValues)
                    {
                        if (con.Name == str.Name)
                        {
                            str.PropertyValue = con.Text;
                        }
                    }
                }
            }
            Properties.Settings.Default.Save();
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            Randomizer.Randomize(ArchivePath.Text, MusicDestination.Text, Convert.ToInt32(NumberOfSongs.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = MusicDirectory.Text;
            //ofd.ShowDialog();
            //string path = ofd.FileName;
            string path = @"D:\Desktop\(30 Seconds To Mars) - A Beautiful Lie - From Yesterday.mp3";
            var song = TagEditor.LoadSong(path);
        }

        private void UpdateBasePath(object sender, EventArgs e)
        {
            Pathing.Archive_Path = ArchivePath.Text;
        }
        private void UpdateBasePath()
        {
            Pathing.Archive_Path = ArchivePath.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"D:\Desktop\(30 Seconds To Mars) - A Beautiful Lie - From Yesterday.mp3";
            var song = TagEditor.LoadSong(path);
            SongTitle.Text = song.GetTitle();
            SongArtist.Text = song.GetArtist();
            SongAlbum.Text = song.GetAlbum();
            LblBitrate.Text = song.GetBitrate().ToString();
            LblDuration.Text = song.GetDuration().ToString();
            LblPath.Text = song.GetPath();
        }
    }
}


//string xml_path = ArchivePath.Text;
//XmlReader read = XmlReader.Create(xml_path + "Songlist.xml");
//List<string> songs = new List<string>();
//while (read.Read())
//{
//    if (read.IsStartElement("Song"))
//    {
//        read.ReadToDescendant("Path");
//        read.MoveToAttribute("Value");
//        string path = read.Value;
//        read.ReadToNextSibling("Details");
//        read.MoveToAttribute("SongName");
//        string song = read.Value;
//        songs.Add(path + song);
//    }
//}
//int i = songs.Count;
//Random rand = new Random(DateTime.Now.Millisecond);
//int songNumber = rand.Next(0, i);
//string songname = songs[songNumber];
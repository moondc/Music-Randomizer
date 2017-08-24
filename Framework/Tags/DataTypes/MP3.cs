using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.IO;
using System.Reflection;

namespace Framework
{
    class MP3 : ITagManager
    {
        private TagLib.Mpeg.AudioFile file = null;
        private string path = String.Empty;
        public void LoadSong(string path)
        {
            file = new TagLib.Mpeg.AudioFile(path);
            this.path = path;
        }

        public string GetPath()
        {
            return this.path;
        }

        public string GetFileName()
        {
            return file.Name;
        }

        public string GetTitle()
        {
            return file.Tag.Title;
        }

        public string GetArtist()
        {
            return file.Tag.AlbumArtists[0];
        }

        public string GetAlbum()
        {
            return file.Tag.Album;
        }

        public void SetFileName(string value)
        {
            string base_path = path.Substring(path.LastIndexOf('\\'));
            System.IO.File.Move(path, base_path + value);
            LoadSong(base_path + value);
        }

        public void SetTitle(string value)
        {
            file.Tag.Title = value;
            file.Save();
        }

        public void SetAlbum(string value)
        {
            file.Tag.Album = value;
            file.Save();
        }

        public void SetArtist(string value)
        {
            file.Tag.AlbumArtists[0] = value;
            file.Save();
        }

        public TimeSpan GetDuration()
        {
            return file.Properties.Duration;
        }

        public int GetBitrate()
        {
            return file.Properties.AudioBitrate;
        }

        public void LogProperties(string path)
        {
            PropertyInfo[] p = file.GetType().GetProperties();
            Log.Dir = path;
            Log.Initialize();
            foreach (PropertyInfo pi in p)
            {
                Log.WriteLine(pi.Name + "\t\t\t" + pi.GetValue(file) + "\n");
            }
            Log.WriteLine();
            Log.WriteLine();

            p = file.Tag.GetType().GetProperties();
            foreach (PropertyInfo pi in p)
            {
                Log.WriteLine(pi.Name + "\t\t\t" + pi.GetValue(file.Tag) + "\n");
            }

            Log.WriteBreak();
            Log.Close();
        }
    }
}

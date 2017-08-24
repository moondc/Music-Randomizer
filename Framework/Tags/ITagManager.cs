using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface ITagManager
    {
        void LoadSong(string path);
        void SetTitle(string value);
        void SetArtist(string value);
        void SetAlbum(string value);
        void SetFileName(string value);
        string GetTitle();
        string GetArtist();
        string GetAlbum();
        string GetFileName();
        TimeSpan GetDuration();
        int GetBitrate();
        string GetPath();
        void LogProperties(string path);
    }
}

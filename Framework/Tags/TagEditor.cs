using System;
using TagLib;
using System.Collections.Generic;


namespace Framework
{
    public static class TagEditor
    {
        public static ITagManager song = null;

        public static ITagManager LoadSong(string path){

            if (path.EndsWith("mp3") || path.EndsWith("MP3"))
            {
                MP3 file = new MP3();
                file.LoadSong(path);
                song = file;
            }
            else if (path.EndsWith("wma") || path.EndsWith("WMA"))
            {
                //current_song = new TagLib.
            }

            return song;
        }
    }
}

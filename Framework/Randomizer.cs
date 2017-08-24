using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Framework
{
    public static class Randomizer
    {
        /// <summary>
        /// Copies number of random songs from xml_list_path to destination
        /// </summary>
        /// <param name="xml_list_path">The Path to the Xml Archive</param>
        /// <param name="destination">Where the songs will be placed</param>
        /// <param name="number">The number of songs</param>
        public static void Randomize(string xml_list_path, string destination, int number){
            xml_list_path += "Songlist.xml";
            destination = FixDestination(destination);
            int num_of_songs = ReadNumber(xml_list_path);
            int[] songnumbers = new int[num_of_songs];
            songnumbers = GetRandomNumbers(number, num_of_songs);
            string[] paths = new string[number];
            paths = GetSongPaths(xml_list_path, songnumbers);
            string[] names = new string[number];
            names = GetSongNames(xml_list_path, songnumbers);
            names = FixNames(destination, names);
            CopyFiles(paths, names);
        }

        // Gets the song paths ex. "D/Music/Linkin Park/Lying From You.mp3"
        private static string[] GetSongPaths(string path, int[] songs)
        {
            XmlReader reader = XmlReader.Create(path);
            int length = songs.Length;
            string[] song_paths = new string[length];
            int count = 0;
            int songindex = 0;
            while (reader.Read())
            {
                if (reader.IsStartElement("Song"))
                {
                    if (songindex < length && songs[songindex] == count)
                    {
                        string dir = "";
                        string songname = "";
                        XmlReader Details = reader.ReadSubtree();
                        Details.ReadToFollowing("Path");
                        dir = Details.GetAttribute("Value");
                        Details.ReadToFollowing("Details");
                        songname = Details.GetAttribute("SongName");
                        Details.Close();
                        song_paths[songindex] = dir + songname;
                        songindex++;
                    }
                    count++;
                }
            }
            return song_paths;
        }

        // Returns just the song names
        private static string[] GetSongNames(string path, int[] songs)
        {
            XmlReader reader = XmlReader.Create(path);
            int length = songs.Length;
            string[] song_paths = new string[length];
            int count = 0;
            int songindex = 0;
            while (reader.Read())
            {
                if (reader.IsStartElement("Song"))
                {
                    if (songindex < length && songs[songindex] == count)
                    {
                        string songname = "";
                        XmlReader Details = reader.ReadSubtree();
                        Details.ReadToFollowing("Path");
                        Details.ReadToFollowing("Details");
                        songname = Details.GetAttribute("SongName");
                        Details.Close();
                        song_paths[songindex] = songname;
                        songindex++;
                    }
                    count++;
                }
            }
            return song_paths;
        }

        // Gets a random permutation of songs
        private static int[] GetRandomNumbers(int num_of_songs, int total_song_count)
        {
            // Create a list of songnumbers for my permutation list
            List<int> songnumbers = new List<int>(total_song_count);
            int[] songs = new int[num_of_songs];
            for (int i = 0; i < total_song_count; i++)
            {
                songnumbers.Add(i);
            }




            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int index = 0;
            for (int i = 0; i < num_of_songs; i++)
            {
                index = songnumbers[rand.Next(0, total_song_count)];
                songs[i] = index;
                songnumbers.Remove(index);
                total_song_count--;
            }

            Array.Sort(songs);

            return songs;
        }

        // Returns the number of songs
        private static int ReadNumber(string path)
        {
            XmlReader reader = XmlReader.Create(path);
            int count = 0;
            while (reader.Read())
            {
                if (reader.IsStartElement("Song"))
                {
                    count++;
                }
            }
            return count;
        }

        // Potentially Fixes destination error
        private static string FixDestination(string destination)
        {
            if (!destination.EndsWith("\\") || !destination.EndsWith("/"))
            {
                destination += "\\";
            }
            return destination;
        }

        // Adds Destination to Song Names
        private static string[] FixNames(string destination, string[] names)
        {
            int length = names.Length;
            for (int i = 0; i < length; i++)
            {
                names[i] = destination + names[i];
            }
            return names;
        }

        // Copys files from left to right
        private static void CopyFiles(string[] paths, string[] names)
        {
            int length = paths.Length;
            for (int i = 0; i < length; i++)
            {
                File.Copy(paths[i], names[i], true);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
namespace Framework
{
    public static class XmlMaker
    {
        static XmlWriter writer = null;


        // Makes an xml file that contains the song titles and the directory they're in

        /// <summary>
        /// Makes an xml file that contains the song titles and the directory they're in.
        /// </summary>
        /// <param name="list">A list of songs</param>
        /// <param name="dir">The path to the base music directroy</param>
        /// <param name="xml_destination">The path to where the xml will be stored</param>
        public static void CreateXmlFromSongs(List<string> list, string dir, string xml_destination){

            writer = getXmlWriter(xml_destination);
            WriteIntro(dir);
            WriteSongNames(list);
            WriteEnd();
        }

        // Creates the xml writer to use, deletes if already existing
        private static XmlWriter getXmlWriter(string dest)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;
            if (File.Exists(dest))
            {
                File.Delete(dest);
            }
            else if(!Directory.Exists(dest))
            {
                Pathing.CreateDirectory(dest);
            }
            XmlWriter write = XmlWriter.Create(dest + "Songlist.xml", settings);
            return write;
        }

        // Writes the intro to the xml file
        private static void WriteIntro(string dir)
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("Songlist");
            writer.WriteStartElement("General_Info");
            writer.WriteAttributeString("Directory", dir);
            writer.WriteAttributeString("Created", DateTime.Now.ToString());
            writer.WriteEndElement();
        }

        // Writes all the songs in the directory to the xml file
        private static void WriteSongNames(List<string> list)
        {
            foreach (string song in list)
            {
                int index=  song.LastIndexOf(@"\") + 1;
                string path = song.Substring(0,index);
                string songname = song.Substring(index);
                writer.WriteStartElement("Song");
                writer.WriteStartElement("Path");
                writer.WriteAttributeString("Value", path);
                writer.WriteEndElement();
                writer.WriteStartElement("Details");
                writer.WriteAttributeString("SongName", songname);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }

        // Writes the end and saves the xml file
        private static void WriteEnd()
        {
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }

}

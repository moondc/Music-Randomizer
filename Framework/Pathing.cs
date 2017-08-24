using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Framework
{
    public static class Pathing
    {
        public static string Archive_Path = String.Empty;

        // Returns the Basic Archive Folder path with "Data\\" appended
        public static string GetDataPath()
        {
            return Archive_Path += "Data\\";
        }

        //Ensures that a directory is at path "path"
        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        
        // Creates the basic structure for the program
        public static void CreateBasicStructure()
        {
            Archive_Path += "Album Art\\";
            CreateDirectory(Archive_Path);
        }

        // Deletes the directory and all folders and files contained within
        public static void DeleteDirectory(string base_path)
        {
            Directory.Delete(base_path, true);
        }
    }
}

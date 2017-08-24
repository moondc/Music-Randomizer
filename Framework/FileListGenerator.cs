using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Framework
{
    public static class FileListGenerator
    {
        /// <summary>
        /// Returns a list of strings of all filenames that match filetypes specified
        /// </summary>
        /// <param name="dir">The directory to run through</param>
        /// <param name="filetypes">The extensions of the files sought</param>
        /// <returns></returns>
        public static List<string> Generate(string dir, string[] filetypes)
         {
             string directory = ValidateName(dir);
             List<string> songnames = GetAllFiles(directory, filetypes);
             return songnames;
         }

        private static string ValidateName(string name)
        {
            if (!name.EndsWith(@"\"))
            {
                name += @"\";
            }
            return name;
        }

        private static List<string> GetAllFiles(string directory, string[] filetypes)
        {
            List<string> results = new List<string>();
            AddFiles(directory, filetypes, results);
            results.Sort();
            return results;
        }

        private static void AddFiles(string dir,string[] filetypes, List<string> results)
        {

            string[] directories = Directory.GetDirectories(dir);
            foreach (string _dir in directories)
            {
                AddFiles(_dir, filetypes, results);
            }

            string[] files = Directory.GetFiles(dir);
            foreach (string file in files)
            {

                foreach (string type in filetypes)
                {
                    if (file.Contains(type))
                    {
                        results.Add(file);
                        break;
                    }
                }
            }
        }

    }
}

using System;
using System.IO;

namespace Framework
{
    static public class Log
    {
        #region Private Variables

        static private DateTime start;
        static private string directory;
        static private StreamWriter writer;

        #endregion

        #region Public Variables

        static public string Dir
        {
            get
            { 
                return directory;
            }
            set
            {
                directory = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sets up a log file
        /// </summary>
        static public void Initialize()
        {
            start = DateTime.Now;
            Pathing.CreateDirectory(Dir);
            CheckFile();
            WriteBeginning();
        }

        /// <summary>
        /// Saves the log file to disk
        /// </summary>
        static public void Close()
        {
            WriteEnd();
            writer.Close();
        }

        /// <summary>
        /// Writes a message to log without a new line character
        /// </summary>
        /// <param name="value"></param>
        static public void Write(string value)
        {
            writer.Write(value);
        }

        /// <summary>
        /// Writes a newline to log
        /// </summary>
        static public void WriteLine()
        {
            writer.WriteLine(string.Empty);
        }

        /// <summary>
        /// Writes x newlines to log
        /// </summary>
        /// <param name="breaks"></param>
        static public void WriteLine(int breaks)
        {
            for (int num = 0; num < breaks; num++)
            {
                writer.WriteLine(string.Empty);
            }
        }

        /// <summary>
        /// Writes message to log
        /// </summary>
        /// <param name="message"></param>
        static public void WriteLine(string message)
        {
            writer.WriteLine(message);
        }

        /// <summary>
        /// Writes 80 Hyphens to log
        /// </summary>
        static public void WriteBreak()
        {
            writer.WriteLine("--------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Writes an exception message
        /// </summary>
        /// <param name="message">The exception thrown</param>
        static public void WriteException(string message)
        {
            writer.WriteLine("Exception: " + message);
        }

        #endregion

        #region Private Methods

        // Checks to see if the file is already there, either appends or creates
        static private void CheckFile()
        {
            DateTime today = DateTime.Now;
            string year = today.Year.ToString();
            string month = today.Month.ToString();
            string day = today.Day.ToString();
            string filename = year + "-" + month + "-" + day + ".log";
            string fullpath = directory + filename;

            if (File.Exists(fullpath))
            {
                writer = File.AppendText(fullpath);
            }
            else
            {
                writer = new StreamWriter(fullpath);
            }
        }

        // Writes the default intro for my logs
        static private void WriteBeginning()
        {
            WriteBreak();
            WriteLine();
        }

        // Writes the default end for my logs
        static private void WriteEnd()
        {
            DateTime end = DateTime.Now;
            TimeSpan ts_start = start.TimeOfDay;
            TimeSpan ts_end = end.TimeOfDay;
            int seconds = Convert.ToInt32(ts_end.Subtract(ts_start).TotalSeconds);

            writer.Write("Duration: ");
            writer.Write(seconds);
            writer.Write(" Seconds");
            writer.Write(writer.NewLine);
        }

        #endregion
    }
}

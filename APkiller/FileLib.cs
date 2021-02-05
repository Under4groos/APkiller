using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APkiller
{
    public static class FileLib
    {
        public static bool IsValid(string path)
        {
            return File.Exists(path) || Directory.Exists(path);
        }
        public static string ReadFile(string pathfile)
        {
            string textFromFile = "";
            using (FileStream fstream = File.Open(pathfile, FileMode.Open))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                UTF8Encoding encode = new UTF8Encoding(true);
                textFromFile = encode.GetString(array);
            }

            return textFromFile;
        }
        public static void WriteFileAsync(string pathfile, string text)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathfile))
            {
                 file.Write(text);
            }
        }

    }
}

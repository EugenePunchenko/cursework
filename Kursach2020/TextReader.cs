using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach2020
{
    static class TextReader
    {
        static public string readText(string path)
        {
            FileInfo fi1 = new FileInfo(path);
            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                s = sr.ReadToEnd();
                
                return s;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach2020
{
    static class TextWriter
    {
        static public void writeText(string path, string text)
        {
            StreamWriter output = new StreamWriter(path);
            output.WriteLine(text);
            output.Close();
        }
    }
}

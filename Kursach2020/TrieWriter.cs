using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kursach2020
{
    static public class TrieWriter
    {
     
        
         public static void Serialize(Trie<string> trie, string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, trie);
            fs.Close();
        }
    }
}

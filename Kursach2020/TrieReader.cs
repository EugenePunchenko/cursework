using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Kursach2020
{
    public class TrieReader
    {
        public Trie<string> Trie { get; }
        public string Path { get; }
        private BinaryFormatter formatter;
        private FileStream fs;
        public TrieReader(string path)
        {
            this.Path = path;
            formatter = new BinaryFormatter();
            fs = new FileStream(this.Path, FileMode.OpenOrCreate);
            try
            {
                this.Trie = (Trie<string>)formatter.Deserialize(fs);
            }
            catch
            {
                Trie = null;
               
            }
            fs.Close();
        }
        public TrieReader()
        {
            this.Trie = null;
            this.Path = null;
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursach2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonFind_Click(object sender, EventArgs e)
        {
            listBoxTerms.Items.Clear();
            folderPathToTrie.ShowDialog();
            Trie<string> trie;
            try
            {

                trie = new TrieReader(folderPathToTrie.SelectedPath + "\\trie.dat").Trie;
            }
            catch
            {
                listBoxTerms.Items.Clear();
                listBoxTerms.Items.Add("Нет дерева в данной папке. Нажмите создать дерево");
                return;
            }

            if (trie.TrySearch(textBoxFind.Text, out string value))
            {
                listBoxTerms.Items.Add(textBoxFind.Text.ToString() + " " + TextReader.readText(value));
            }
            else
            {
                listBoxTerms.Items.Add("Не найдено");
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            folderPathToTrie.ShowDialog();
            string pathToTriee = folderPathToTrie.SelectedPath + "\\trie.dat";
            Trie<string> trie = new TrieReader(pathToTriee).Trie;
            if (trie == null)
            {
                listBoxTerms.Items.Add("Не удалось открыть дерево.");
                return;
            }
            if (textBoxTerm.Text != "" && textBoxDef.Text != "")
            {
                string pathToDefss = folderPathToTrie.SelectedPath + "\\" + textBoxTerm.Text + ".txt";
                FileInfo fi = new FileInfo(pathToDefss);
                if (!fi.Exists)
                {

                    using (StreamWriter sw = fi.CreateText())
                    {
                        sw.WriteLine(textBoxTerm.Text);
                    }
                }
                TextWriter.writeText(pathToDefss, textBoxDef.Text);
                trie.Add(textBoxTerm.Text, pathToDefss);
                TrieWriter.Serialize(trie, pathToTriee);
            }
        }

        private void buttonCreateTrie_Click(object sender, EventArgs e)
        {
            folderPathToTrie.ShowDialog();
            string pathToTriee = folderPathToTrie.SelectedPath + "\\trie.dat";
            Trie<string> trie = new Trie<string>();
            string pathToDefss = folderPathToTrie.SelectedPath + "\\привет.txt";
            TextWriter.writeText(pathToDefss, "универсальное приветствие");
            trie.Add("привет", pathToDefss);
            TrieWriter.Serialize(trie, pathToTriee);
        }
    }
}

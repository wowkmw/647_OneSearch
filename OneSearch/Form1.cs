using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq; //for jarray


namespace OneSearch
{
    public partial class Form1 : Form
    {
        string jsonFilePath;
        JArray collection;
        string indexPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LuceneCore myLuceneApp = new LuceneCore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            jsonFilePath = openFile.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonImport myJson = new JsonImport();
            LuceneCore myLucene = new LuceneCore();
            collection = myJson.JsonCollection(jsonFilePath);
            myLucene.CreateIndex(indexPath);
            int numofDoc = 82326;
            //System.Console.WriteLine("Creating query index using the first {0} results...", numofDoc);
            int docID = 0;
            while (docID < numofDoc)
            {
                int i = 0;
                foreach (var j in collection[docID]["passages"])
                {
                    myLucene.IndexText(collection[docID]["passages"][i]["url"].ToString() + "\n" + collection[docID]["passages"][i]["passage_text"].ToString());
                    i++;
                }
                docID++;
            }
            //Console.WriteLine("All documents added.");
            myLucene.CleanUpIndexer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            indexPath = path.SelectedPath;
        }
    }
}

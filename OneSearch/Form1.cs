using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;



namespace OneSearch
{
    public partial class Form1 : Form
    {
        internal static Form1 Form1Instance;
        internal string jsonFilePath;
        internal JArray collection;
        internal LuceneCore myLucene;
        internal string indexPath;
        internal string searchTerm;
        List<Dictionary<string, string>> resultList;

        public Form1()
        {
            Form1Instance = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            jsonFilePath = openFile.FileName;
            jsonPath.Text = jsonFilePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Minimized;
            //ShowInTaskbar = false;
            //Visible = false;
            //Form2 form2 = new Form2(this);
            //form2.Show();
            JsonImport myJson = new JsonImport();
            collection = myJson.JsonCollection(jsonFilePath);
            myLucene = new LuceneCore();
            DateTime a = DateTime.Now;
            myLucene.CreateIndex(indexPath);
            //int numofDoc = 82326;
            int numofDoc = 12326;
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
            myLucene.CleanUpIndexer();
            DateTime b = DateTime.Now;
            TimeSpan c = b - a;
            double seconds = c.TotalSeconds;
            MessageBox.Show("The indexing took " + seconds.ToString() + " seconds");
            myLucene.CreateSearcher();
            MessageBox.Show("Searcher ready, enter keywords to start searching...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            indexPath = path.SelectedPath;
            showIndexPath.Text = indexPath;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchTerm = textBox3.Text;
            int docNum = 100;
            int count = 0;
            resultList = myLucene.SearchText(searchTerm, docNum);
            foreach (var k in resultList)
            {
                string[] row = { resultList[count]["rank"], resultList[count]["score"], resultList[count]["result"] };
                var listViewItem = new ListViewItem(row);
                ResulttView.Items.Add(listViewItem);
                count++;
            }
            //myLucene.CleanUpSearcher();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            if (myLucene != null)
            {
                myLucene.CleanUpSearcher();
            }
            Application.Exit();
        }

        private void ResulttView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

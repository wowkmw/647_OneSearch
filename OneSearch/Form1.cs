using System;
using System.Collections.Generic;
using System.IO;
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
        internal string jsonFilePath = "";
        internal JArray collection;
        internal LuceneCore myLucene;
        internal string indexPath = "";
        internal string searchTerm = "";
        List<Dictionary<string, string>> resultList;
        internal int queryCount = 0;

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
            openFile.Filter = "json files(*.json) | *.json";
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
            if (jsonFilePath is "")
            {
                MessageBox.Show("Please select a valid json source file!");
            }
            else
            {
                if (indexPath is "")
                {
                    MessageBox.Show("Please select a path for indexing");
                }
                else
                {
                    JsonImport myJson = new JsonImport();
                    collection = myJson.JsonCollection(jsonFilePath);
                    myLucene = new LuceneCore();
                    DateTime a = DateTime.Now;
                    myLucene.CreateIndex(indexPath);
                    //int numofDoc = 82326;
                    int numofDoc = 25000;
                    int docID = 0;
                    while (docID < numofDoc)
                    {
                        int i = 0;
                        foreach (var j in collection[docID]["passages"])
                        {
                            myLucene.IndexText(collection[docID]["passages"][i]["url"].ToString() + "\n\n" + 
                                collection[docID]["passages"][i]["passage_text"].ToString(), 
                                collection[docID]["passages"][i]["passage_ID"].ToString());
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
            }
            
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
            ResulttView.Items.Clear();
            ResulttView.Controls.Clear();
            searchTerm = textBox3.Text;
            if (searchTerm is "")
            {
                MessageBox.Show("Please enter some keyword!");
            }
            else
            {
                int docNum = 100;
                int count = 0;
                DateTime a = DateTime.Now;
                myLucene.CreateSearcher();
                resultList = myLucene.SearchText(searchTerm, docNum);
                myLucene.CleanUpSearcher();
                DateTime b = DateTime.Now;
                TimeSpan c = b - a;
                double seconds = c.TotalSeconds;
                MessageBox.Show("The searching took " + seconds.ToString() + " seconds");
                queryCount++;
                foreach (var k in resultList)
                {
                    string[] row = { resultList[count]["rank"], resultList[count]["score"], resultList[count]["result"] };
                    var listViewItem = new ListViewItem(row);
                    ResulttView.Items.Add(listViewItem);
                    count++;
                }
            }

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
            if (ResulttView.SelectedItems.Count > 0)
            {
                int rank = Int32.Parse(ResulttView.SelectedItems[0].Text);
                MessageBox.Show(resultList[rank - 1]["result"], "Entire Passage");
            }
        }

        private void SaveResults_Click(object sender, EventArgs e)
        {
            string filepath = "";
            SaveFileDialog saveMe = new SaveFileDialog();
            saveMe.Filter = "Text Files | *.txt";
            saveMe.ShowDialog();
            filepath = saveMe.FileName;
            if (filepath is "")
            {
                MessageBox.Show("Please select the save locatiion");
            }
            else
            {
                
                Program.ResultSaver(queryCount, resultList, filepath);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

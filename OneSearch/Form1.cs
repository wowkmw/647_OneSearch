﻿using System;
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
using Lucene.Net.Search;



namespace OneSearch
{
    public partial class Form1 : Form
    {
        internal static Form1 Form1Instance;
        private string jsonFilePath = "";
        private JArray collection;
        private LuceneCore myLucene;
        private string indexPath = "";
        private string searchTerm = "";
        private List<Dictionary<string, string>> resultList;
        private int queryCount = 0;
        //private int numofDoc = 82326;
        private int numofDoc = 10000;

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
                    DateTime ja = DateTime.Now;
                    JsonImport myJson = new JsonImport();
                    collection = myJson.JsonCollection(jsonFilePath);
                    DateTime jb = DateTime.Now;
                    TimeSpan jc = jb - ja;
                    double jseconds = jc.TotalSeconds;
                    myLucene = new LuceneCore();
                    DateTime a = DateTime.Now;
                    myLucene.CreateIndex(indexPath);
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
                    MessageBox.Show("The json file takes " + jseconds.ToString() + "seconds to be imported\n" + "The indexing took " + seconds.ToString() + " seconds");
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            ResulttView.Items.Clear();
            ResulttView.Controls.Clear();
            searchTerm = textBox3.Text;
            string processedQuery;
            double seconds;
            if (searchTerm is "")
            {
                MessageBox.Show("Please enter some keyword!");
            }
            else if (myLucene is null)
            {
                MessageBox.Show("Search engine not yet initialized!");
            }
            else
            {
                bool check = false;
                if (AsIsBox.Checked)
                {
                    check = true;
                    DateTime a = DateTime.Now;
                    myLucene.CreateSearcher();
                    resultList = myLucene.SearchText(searchTerm, numofDoc, check, out processedQuery);
                    myLucene.CleanUpSearcher();
                    DateTime b = DateTime.Now;
                    TimeSpan c = b - a;
                    seconds = c.TotalSeconds;
                }
                else
                {
                    DateTime a = DateTime.Now;
                    myLucene.CreateSearcher();
                    resultList = myLucene.SearchText(searchTerm, numofDoc, check, out processedQuery);
                    myLucene.CleanUpSearcher();
                    DateTime b = DateTime.Now;
                    TimeSpan c = b - a;
                    seconds = c.TotalSeconds;
                }
                
                FinalWordBox.Text = processedQuery;
                queryCount++;
                int numofresult = resultList.Count;
                TotalResultBox.Text = numofresult.ToString();
                MessageBox.Show("The searching took " + seconds.ToString() + " seconds");
                MessageBox.Show("Number of results is " + numofresult + "\nShowing the first 20 results...");
                if (numofresult < 20)
                {
                    for (int i = 0; i < numofresult; i++)
                    {
                        string[] row = { resultList[i]["rank"], resultList[i]["score"], resultList[i]["result"] };
                        var listViewItem = new ListViewItem(row);
                        ResulttView.Items.Add(listViewItem);
                    }
                }
                else
                {
                    for (int i = 0; i < 20; i++)
                    {
                        string[] row = { resultList[i]["rank"], resultList[i]["score"], resultList[i]["result"] };
                        var listViewItem = new ListViewItem(row);
                        ResulttView.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            //clean-up the index folder when exiting the app
            if (indexPath != "")
            {
                DirectoryInfo di = new DirectoryInfo(indexPath);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
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
            if (resultList != null)
            {
                if (filepath != "")
                {
                    Program.ResultSaver(queryCount, resultList, filepath);
                }
            }
            else
            {
                MessageBox.Show("Search something first...");
            }
        }

        private void AsIsBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

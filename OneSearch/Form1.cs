﻿using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Lucene.Net.Search;
using NHunspell;



namespace OneSearch
{
    public partial class Form1 : Form
    {
        internal static Form1 Form1Instance;
        private string jsonFilePath = "";
        internal JArray collection;
        private LuceneCore myLucene;
        private string indexPath = "";
        private string searchTerm = "";
        private List<Dictionary<string, string>> resultList;
        private int queryCount = 0;
        private int numofDoc = 82326;
        //private int numofDoc = 10000;
        private Hunspell hunspell;

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
                    //Save the cranqrel1.txt and cranquel2.txt for evaluation
                    //string filepath2 = @"C:\Users\MKUO\Dropbox\QUT\647\project\results\cranqrel1.txt";
                    //string filepath2 = @"C:\Users\bill6\Downloads\Semester4\IFN647 Advanced Information Storage and Retrieval\Assessment_2\cranqrel1.txt";
                    //Program.CranSaver(filepath2,collection);
                    //string filepath3 = @"C:\Users\MKUO\Dropbox\QUT\647\project\results\cranqrel2.txt";
                    //string filepath3 = @"C:\Users\bill6\Downloads\Semester4\IFN647 Advanced Information Storage and Retrieval\Assessment_2\cranqrel2.txt";
                    //Program.CranSaver2(filepath3, collection);
                    myLucene = new LuceneCore();
                    DateTime a = DateTime.Now;
                    myLucene.CreateIndex(indexPath);
                    int docID = 0;
                    while (docID < numofDoc)
                    {
                        int i = 0;
                        foreach (var j in collection[docID]["passages"])
                        {
                            string temp = collection[docID]["passages"][i]["url"].ToString();
                            string processedURL = Program.UrlPreprocessor(temp);

                            myLucene.IndexText(processedURL,
                                collection[docID]["passages"][i]["passage_ID"].ToString(), 
                                collection[docID]["passages"][i]["passage_text"].ToString(),
                                collection[docID]["query_id"].ToString(),
                                collection[docID]["query"].ToString(),
                                collection[docID]["passages"][i]["url"].ToString());
                            i++;
                        }
                        docID++;
                    }
                    myLucene.CleanUpIndexer();
                    DateTime b = DateTime.Now;
                    JsonBS.Text = (jb - ja).TotalSeconds.ToString();
                    IndexBS.Text = (b - a).TotalSeconds.ToString();
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
                hunspell = new Hunspell("en_us.aff", "en_us.dic");
                bool check = false;
                if (AsIsBox.Checked)
                {
                    check = true;
                    DateTime a = DateTime.Now;
                    myLucene.CreateSearcher();
                    resultList = myLucene.SearchText(searchTerm, numofDoc, check, out processedQuery);
                    myLucene.CleanUpSearcher();
                    DateTime b = DateTime.Now;
                    seconds = (b - a).TotalSeconds;
                }
                else
                {
                    if (SpellCheckB.Checked)
                    {
                        if (hunspell.Spell(searchTerm))
                        {
                        }
                        else
                        {
                            List<string> suggesstions = new List<string>();
                            suggesstions = hunspell.Suggest(searchTerm);
                            string suggestedWord = "Spell Check Suggestions: ";
                            foreach (string item in suggesstions)
                            {
                                suggestedWord = suggestedWord + " " + item;
                            }
                            MessageBox.Show(suggestedWord);
                        }
                        
                    }
                    DateTime a = DateTime.Now;
                    myLucene.CreateSearcher();
                    resultList = myLucene.SearchText(searchTerm, numofDoc, check, out processedQuery);
                    myLucene.CleanUpSearcher();
                    DateTime b = DateTime.Now;
                    seconds = (b - a).TotalSeconds;
                }
                
                FinalWordBox.Text = processedQuery;
                queryCount++;
                int numofresult = resultList.Count;
                TotalResultBox.Text = numofresult.ToString();
                SearchBS.Text = seconds.ToString();
                if (numofresult < 30)
                {
                    for (int i = 0; i < numofresult; i++)
                    {
                        string[] row = { resultList[i]["rank"], resultList[i]["score"], resultList[i]["url"], resultList[i]["result"] };
                        var listViewItem = new ListViewItem(row);
                        ResulttView.Items.Add(listViewItem);
                    }
                }
                else
                {
                    for (int i = 0; i < 30; i++)
                    {
                        string[] row = { resultList[i]["rank"], resultList[i]["score"], resultList[i]["url"], resultList[i]["result"] };
                        var listViewItem = new ListViewItem(row);
                        ResulttView.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            //clean-up the index folder when exiting the app
            //if (indexPath != "")
            //{
            //    DirectoryInfo di = new DirectoryInfo(indexPath);
            //    foreach (FileInfo file in di.GetFiles())
            //    {
            //        file.Delete();
            //    }
            //}
            Application.Exit();
        }

        private void ResulttView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResulttView.SelectedItems.Count > 0)
            {
                int rank = Int32.Parse(ResulttView.SelectedItems[0].Text);
                MessageBox.Show(resultList[rank - 1]["url"] + "\n\n" + resultList[rank - 1]["result"], "Entire Passage");
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
            if (AsIsBox.Checked)
            {
                SpellCheckB.Enabled = false;
            }
            else if (!AsIsBox.Checked)
            {
                SpellCheckB.Enabled = true;
            }
            
        }

        private void SpellCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (SpellCheckB.Checked)
            {
                AsIsBox.Enabled = false;
            }
            else if (!SpellCheckB.Checked)
            {
                AsIsBox.Enabled = true;
            }
        }

        private void FinalWordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project was part of the IFN643 coursework.","About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            0, "https://github.com/wowkmw/647_OneSearch",
            "");
        }
    }
}

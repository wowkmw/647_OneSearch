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
    public partial class Form2 : Form
    {
        //internal Form1 form1;
        //internal JArray collection;
        //internal LuceneCore myLucene;

        public Form2(Form1 aa)
        {
            //form1 = aa;
            //InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //JsonImport myJson = new JsonImport();
            //collection = myJson.JsonCollection(form1.jsonFilePath);
            //myLucene.CreateIndex(form1.indexPath);
            ////int numofDoc = 82326;
            //int numofDoc = 12326;
            //int docID = 0;
            //DateTime a = DateTime.Now;
            //while (docID < numofDoc)
            //{
            //    int i = 0;
            //    foreach (var j in collection[docID]["passages"])
            //    {
            //        myLucene.IndexText(collection[docID]["passages"][i]["url"].ToString() + "\n" + collection[docID]["passages"][i]["passage_text"].ToString());
            //        i++;
            //    }
            //    docID++;
            //}
            //myLucene.CleanUpIndexer();
            //DateTime b = DateTime.Now;
            //TimeSpan c = b - a;
            //double seconds = c.TotalSeconds;
            //MessageBox.Show("The indexing took " + seconds.ToString() + " seconds");
        }
    }
}

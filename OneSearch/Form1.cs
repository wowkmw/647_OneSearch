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
        string filePath;
        JArray collection;

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
            filePath = openFile.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonImport myJson = new JsonImport();
            collection = myJson.JsonCollection(filePath);
        }
    }
}

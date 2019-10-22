using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace OneSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // This is Bill
        }
        public static void ResultSaver(int queryCout, List<Dictionary<string, string>> resultList, string filePath )
        {
            StreamWriter writer = new StreamWriter(filePath, append: true);
            
            int counter = 0;
            foreach (var a in resultList)
            {
                writer.WriteLine("00"+queryCout.ToString() + "\tQ0\t" + resultList[counter]["passID"] + "\t" + resultList[counter]["rank"] + "\t" +
                    resultList[counter]["score"] + "\tBaselineSystem");
                counter++;
            }
            writer.Dispose();
            writer.Close();           
        }
        public static void CranSaver(string filepath2, JArray collection)
        {
            StreamWriter writer2 = new StreamWriter(filepath2);
            int counter = 0;
            foreach (var a in collection)
            {
                int meter = 0;
                foreach (var b in collection[counter]["passages"])
                {
                    if (collection[counter]["passages"][meter]["is_selected"].ToString() == "1")
                    {
                        writer2.WriteLine(String.Format("{0}\t0\t{1}\t1", collection[counter]["query_id"], collection[counter]["passages"][meter]["passage_ID"]));
                    }
                    meter++;
                }
                counter++;
            }
            writer2.Dispose();
            writer2.Close();
        }
        public static void CranSaver2(string filepath2, JArray collection)
        {
            StreamWriter writer2 = new StreamWriter(filepath2);
            int counter = 0;
            foreach (var a in collection)
            {
                int meter = 0;
                foreach (var b in collection[counter]["passages"])
                {                    
                    writer2.WriteLine(String.Format("{0}\t0\t{1}\t1", collection[counter]["query_id"], collection[counter]["passages"][meter]["passage_ID"]));                   
                    meter++;
                }
                counter++;
            }
            writer2.Dispose();
            writer2.Close();
        }
    }
}

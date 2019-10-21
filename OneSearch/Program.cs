using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void ResultSaver(int queryCout, List<Dictionary<string, string>> resultList, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath, append: true);
            int counter = 0;
            foreach (var a in resultList)
            {
                writer.WriteLine(queryCout.ToString() + "\tQ0\t" + resultList[counter]["passID"] + "\t" + resultList[counter]["rank"] + "\t" +
                    resultList[counter]["score"] + "\tBaselineSystem");
                counter++;
            }
            writer.Dispose();
            writer.Close();
        }
    }
}

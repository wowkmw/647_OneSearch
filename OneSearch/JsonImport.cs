using System;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Newtonsoft.Json.Linq; //for jarray
using Newtonsoft.Json;

namespace OneSearch
{
    class JsonImport
    {
        public JArray collection;
        public JArray JsonCollection(string path)
        {
            //Console.WriteLine("Loading collection.json file to the system...");
            StreamReader sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            sr.Close();
            collection = (JArray)JsonConvert.DeserializeObject(json);
            return collection;
        }
    }
}
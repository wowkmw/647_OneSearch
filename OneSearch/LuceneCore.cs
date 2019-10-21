using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
//using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using System.Windows.Forms;
using System.Collections.Generic;
//using Lucene.Net.Analysis.Snowball; // for snowball analyser 
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq; //for jarray

namespace OneSearch
{
    public class LuceneCore
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        public static QueryParser parser;

        //Lucene.Net.Search.Similarity newSimilarity;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";
        const string passID = "pID";


        public LuceneCore()
        {
            luceneIndexDirectory = null;
            writer = null;
            //analyzer = new Lucene.Net.Analysis.WhitespaceAnalyzer();
            //analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();

            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);

            //newSimilarity = new NewSimilarity();
        }
        /// <summary>
        /// Creates the index at a given path
        /// </summary>
        /// <param name="indexPath">The pathname to create the index</param>
        public void CreateIndex(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
            //writer.SetSimilarity(newSimilarity);
        }

        /// <summary>
        /// Indexes a given string into the index
        /// </summary>
        /// <param name="text">The text to index</param>
        public void IndexText(string text, string id)
        {

            Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED_NO_NORMS, Field.TermVector.NO);
            Field idField = new Field(passID, id, Field.Store.YES, Field.Index.ANALYZED_NO_NORMS, Field.TermVector.NO);
            Document doc = new Document();
            doc.Add(field);
            doc.Add(idField);
            writer.AddDocument(doc);
        }

        /// <summary>
        /// Flushes the buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }


        /// <summary>
        /// Creates the searcher object
        /// </summary>
        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
            //searcher.Similarity = newSimilarity;
        }

        /// <summary>
        /// Searches the index for the querytext
        /// </summary>
        /// <param name="querytext">The text to search the index</param>
        public List<Dictionary<string, string>> SearchText(Query querytext, int DocNum)
        {
            //System.Console.WriteLine("Searching for " + querytext);
            //querytext = querytext.ToLower();
            //Query query = parser.Parse(querytext);
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();

            TopDocs results = searcher.Search(querytext, DocNum);
            
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Dictionary<string, string> dict;
                dict = new Dictionary<string, string>();
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                string myPassID = doc.Get(passID).ToString();
                dict.Add("rank", rank.ToString());
                dict.Add("score", scoreDoc.Score.ToString());
                dict.Add("result", myFieldValue.ToString());
                dict.Add("passID", myPassID.ToString());
                //resultText += "Rank: " + rank + " Score: " + scoreDoc.Score + "\nResult: " + myFieldValue + "\n\n";
                resultList.Add(dict);
                //Explanation ex = searcher.Explain(query, scoreDoc.Doc);
                //Console.WriteLine(ex);
            }
            return resultList;
        }

        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }

    }
}

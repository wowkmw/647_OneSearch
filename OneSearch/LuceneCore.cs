﻿using System;
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
using Lucene.Net.Analysis.Snowball; // for snowball analyser 
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq; //for jarray

namespace OneSearch
{
    public class LuceneCore
    {
        private Lucene.Net.Store.Directory luceneIndexDirectory;
        private Lucene.Net.Analysis.Analyzer analyzer;
        private Lucene.Net.Analysis.Analyzer AsIsanalyzer;
        private Lucene.Net.Index.IndexWriter writer;
        private IndexSearcher searcher;
        private QueryParser parser;
        private QueryParser AsIsparser;

        //Lucene.Net.Search.Similarity newSimilarity;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";
        const string passID = "pID";
        const string passText = "pText";


        public LuceneCore()
        {
            //the stopword is adapted from https://github.com/pyelasticsearch/pyelasticsearch
            string STOPWORDS = "a able about across after all almost also am among an and " +
                                "any are as at be because been but by can cannot could dear " +
                                "did do does either else ever every for from get got had has " +
                                "have he her hers him his how however i if in into is it its " +
                                "just least let like likely may me might most must my " +
                                "neither no nor not of off often on only or other our own " +
                                "rather said say says she should since so some than that the " +
                                "their them then there these they this tis to too twas us " +
                                "wants was we were what when where which while who whom why " +
                                "will with would yet you your";
            string[] stopArray = STOPWORDS.Split();

            luceneIndexDirectory = null;
            writer = null;
            AsIsanalyzer = new Lucene.Net.Analysis.WhitespaceAnalyzer();
            //analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            //analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
            analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(VERSION, "English", stopArray);

            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            AsIsparser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, AsIsanalyzer);

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
        public void IndexText(string text, string id, string passT)
        {
            //using only the url for indexing
            Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.NO);
            //using only the url for indexing
            Field idField = new Field(passID, id, Field.Store.YES, Field.Index.NO, Field.TermVector.NO);
            Field textField = new Field(passText, passT, Field.Store.YES, Field.Index.NO, Field.TermVector.NO);
            Document doc = new Document();
            
            doc.Add(field);
            doc.Add(idField);
            doc.Add(textField);
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
        public List<Dictionary<string, string>> SearchText(string querytext, int DocNum, bool check, out string processedQuery)
        {
            Query query;
            if (check)
            {
                //querytext = querytext.ToLower();
                query = AsIsparser.Parse("\"" + querytext + "\"");
            }
            else
            {
                querytext = querytext.ToLower();
                query = parser.Parse(querytext);
            }
            
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            processedQuery = query.ToString();
            TopDocs results = searcher.Search(query, DocNum);
            
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Dictionary<string, string> dict;
                dict = new Dictionary<string, string>();
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                string myPassID = doc.Get(passID).ToString();
                string myPassText = doc.Get(passText).ToString();
                dict.Add("rank", rank.ToString());
                dict.Add("score", scoreDoc.Score.ToString());
                dict.Add("result", myPassText.ToString());
                dict.Add("passID", myPassID.ToString());
                dict.Add("url", myFieldValue.ToString());
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

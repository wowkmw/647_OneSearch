using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Search;

namespace OneSearch
{
    public class NewSimilarity : DefaultSimilarity
    {
        public override float Tf(float freq)
        {
            return (float)System.Math.Sqrt(freq); //This is the place to modify th defaul equation
        }
    }
}

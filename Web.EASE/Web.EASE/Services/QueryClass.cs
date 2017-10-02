using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.EASE.Services
{
    public class QueryClass
    {
        private ReadFileService _readFileService;

        private List<string> dictionary;

        public QueryClass()
        {
            dictionary = _readFileService.GetDictionary;
        }

        public List<IGrouping<char,string>> GetWordsByQuery(string from, string to)
        {
            var collection = QuaryFromDictionary(from, to).GroupBy(g => g[0]).ToList();

            return collection;
        }

        private List<string> QuaryFromDictionary(string from, string to)
        {
            int beginIndex = dictionary.FindIndex(a => a == from);
            int endIndex = dictionary.FindIndex(a => a == to);
            int count = endIndex - beginIndex;

            return dictionary.GetRange(beginIndex, count).ToList();
        }
    }
}
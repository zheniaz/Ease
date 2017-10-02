using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.EASE.Models;

namespace Web.EASE.Services
{
    public class QueryClass
    {
        private ReadFileService _readFileService = new ReadFileService();

        private List<string> dictionary;

        public QueryClass()
        {
            dictionary = _readFileService.GetDictionary;
        }

        public List<WordSetModel> GetWordsByQuery(string from, string to)
        {
            var collection = QuaryFromDictionary(from, to).GroupBy(g => g[0]).ToList();

            var convertedList = Convert(collection);

            return convertedList;
        }

        private List<string> QuaryFromDictionary(string from, string to)
        {
            int beginIndex = dictionary.FindIndex(a => a == from);
            int endIndex = dictionary.FindIndex(a => a == to);
            int count = endIndex - beginIndex + 1;

            return dictionary.GetRange(beginIndex, count).ToList();
        }

        private List<WordSetModel> Convert(List<IGrouping<char, string>> convertFrom)
        {
            List<WordSetModel> groupByCollection = new List<WordSetModel>();
            WordSetModel itemSet;

            foreach (var item in convertFrom)
            {
                itemSet = new WordSetModel { Key = item.Key, WordList = item.ToList() };
                groupByCollection.Add(itemSet);
            }

            return groupByCollection;
        }
    }
}
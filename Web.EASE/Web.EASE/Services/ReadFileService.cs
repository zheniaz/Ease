using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Web.EASE.Services
{
    public class ReadFileService
    {
        private List<string> _wordSet;
        public List<string> GetDictionary { get { return _wordSet; } }

        public ReadFileService()
        {
            _wordSet = GetWordSet();
        }

        public List<string> GetWordSet()
        {
            var wordSet = new List<string>();

            try
            {
                using (StreamReader _str = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"App_Data\dictionary.txt")))
                {
                    string line;

                    while ((line = _str.ReadLine()) != null)
                    {
                        wordSet.Add(line);
                    }
                }
            }
            catch (Exception e)
            {

            }

            return wordSet;
        }
    }
}

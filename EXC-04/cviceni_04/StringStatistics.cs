using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace cviceni_04
{
    class StringStatistics
    {
        private String text;
        private readonly char[] delimiters = { ' ', '\r', '\n' };

        public StringStatistics(string input)
        {
            this.text = input;
        }

        public int getWordsCount()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            return this.text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int getLinesCount()
        {
            char[] delimiters = new char[] {'\n'};
            return this.text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int getSentenceCount()
        {
            return Regex.Matches(text, "[^?!.][!?.] *[\\n]*[A-Z]", RegexOptions.Multiline).Count+1;
        }

        public string getLongestWord()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] wordArray = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var sort = wordArray.OrderBy(n => n.Length);
            var longest = sort.LastOrDefault();
            string result = "";
            foreach (var word in sort)
            {
                if (word.Length == longest.Length)
                {
                    result += String.Join(", ", word, " ");
                }
            }
            return result;
        }

        public string getShortestWord()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] wordArray = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var sort = wordArray.OrderBy(n => n.Length);
            var shortest = sort.FirstOrDefault();
            string result = "";
            foreach (var word in sort)
            {
                if (word.Length == shortest.Length)
                {
                    result += String.Join(", ", word, " ");
                }
            }
            return result;
        }

        public string getSortedByAlphapeth()
        {
            List<string> wordList = new List<string>();
            char[] delimiters = new char[] { ' ', '\r', '\n', ')', '(', '.' };
            wordList = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            wordList.Sort();
            return string.Join(" ", wordList);
        }

        /*
        public string[] getMostFrequentWord()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var nameGroup = this.text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x);
            var maxCount = nameGroup.Max(g => g.Count());
            return nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();
        }
        */

    }
}

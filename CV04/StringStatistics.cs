using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace cv04
{
    public class StringStatistics
    {
        public string Text { get; set; }

        public StringStatistics(string text)
        {
            this.Text = text;
        }

        public int NumberOfWords()
        {
            char[] delimiters = { ' ', '\n' };
            return Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int NumberOfLines()
        {
            return Text.Split('\n').Length;
        }

        public int NumberOfSentences()
        {
            return Regex.Matches(Text, @"[.!?]+").Count;
        }

        public string[] LongestWords()
        {
            var words = Regex.Split(Text, @"\W+");
            var maxLength = words.Max(word => word.Length);
            return words.Where(word => word.Length == maxLength).ToArray();
        }

        public string[] ShortestWords()
        {
            var words = Regex.Split(Text, @"\W+");
            var minLength = words.Where(word => !string.IsNullOrWhiteSpace(word)).Min(word => word.Length);
            return words.Where(word => word.Length == minLength).ToArray();
        }

        public string[] MostCommonWords()
        {
            var words = Regex.Split(Text, @"\W+");
            var wordCounts = words.GroupBy(word => word.ToLower())
                                  .OrderByDescending(group => group.Count())
                                  .Select(group => group.Key)
                                  .ToArray();
            return wordCounts;
        }

        public string[] AlphabeticallySortedWords()
        {
            var words = Regex.Split(Text, @"\W+");
            Array.Sort(words, StringComparer.InvariantCultureIgnoreCase);
            return words;
        }
    }
}

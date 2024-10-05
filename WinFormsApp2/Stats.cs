using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2
{
    public class Stats
    {
        public string Text {  get; set; }
        public int CountOfChars { get; set; }
        public int CountOfWords { get; set; }
        public int CountOfLines { get; set; }
        public int CountOfUniqueWords { get; set; }

        public List<string> words { get; set; }
        public List<string> UniqueWords { get; set; }
        public string minWord { get; set; }
        public string maxWord { get; set; }

        public Stats(string text)
        {
            Text = text;
            CountOfChars = 0;
            CountOfWords = 0;
            UniqueWords = new List<string>();
            CountOfLines = 0;
            words = new List<string>();
            minWord = string.Empty;
            maxWord = string.Empty;

            CountNumberOfChars();
            CountNumberOfWords();
            CountNumberOfLines();
            CountNumberOfUniqueWords();
            FindMaxAndMinWords();
        }

        public override string ToString()
        {
            return $"Количество символов: {CountOfChars}\n Количество слов: {CountOfWords}\n Количество предложений: {CountOfLines}\n " +
                $"\n Количество уникальных слов: {CountOfUniqueWords}\n Самое короткое слово: {minWord}\n Самое длинное слово: {maxWord}";
        }

        public void CountNumberOfChars()
        {
            CountOfChars = Text.Length;
        }

        public void CountNumberOfWords()
        {
            words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            CountOfWords = words.Count;
        }

        public void CountNumberOfLines()
        {
            var sentences = Regex.Split(Text, @"[.!?]\s*");
            CountOfLines = sentences.Length;
        }

        public void CountNumberOfUniqueWords()
        {

            words = Text.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(word => word.ToLower()).ToList();

            UniqueWords = words.GroupBy(word => word)
                                   .Where(group => group.Count() == 1)
                                   .Select(group => group.Key).ToList();

            CountOfUniqueWords = UniqueWords.Count();
        }

        public void FindMaxAndMinWords()
        {
            minWord = words.OrderBy(word => word.Length).First();
            maxWord = words.OrderByDescending(word => word.Length).First();
        }
    }
}

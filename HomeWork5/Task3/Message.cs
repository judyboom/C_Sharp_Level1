using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public static class Message
    {

        public static string GetWordsLessNLetters(string str, int n)
        {
            List<string> wordsList = StringToList(str);
            List<string> resultWords = new List<string>();
            foreach (var word in wordsList)
            {
                if (word.Length < n)
                {
                    resultWords.Add(word);
                }
            }
            return string.Join(" ", resultWords);
        }

        public static string DeleteWordsEndWithS(ref string str, char symbol)
        {
            List<string> wordsList = StringToList(str);
            List<string> resultWords = new List<string>();
            foreach (var word in wordsList)
            {
                if (word[word.Length-1] != symbol)
                {
                    resultWords.Add(word);
                }
            }
            str = string.Join(" ", resultWords);
            return str;
        }

        public static string GetMaxLenthWord(string str) //первое вхождение
        {
            List<string> wordsList = StringToList(str);
            int maxLenght = MaxLenth(wordsList);

            return string.Join(" ", wordsList.First(s => s.Length == maxLenght));
        }

        public static string GetMaxLenthWords(string str) //все слова с максимальной длинной
        {
            List<string> wordsList = StringToList(str);
            int maxLenght = MaxLenth(wordsList);

            return string.Join(" ", wordsList.Where(s => s.Length == maxLenght));
        }

        public static string GetMaxLenthWordsStrBuilder(string str) //все слова с максимальной длинной
        {
            List<string> wordsList = StringToList(str);
            int maxLenght = MaxLenth(wordsList);
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Length == maxLenght)
                {
                    st.Append(wordsList[i]);
                    st.Append(" ");
                }
            }
            return st.ToString();
        }

        public static Dictionary<string, int> FrequencyDic(List<string> words, string mes)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            List<string> mesList = StringToList(mes);
            foreach (var w in words)
            {
                result.Add(w, mesList.Count(s => s == w));
            }
            return result;
        }

        static int MaxLenth(List<string> words)
        {
            return words.Max(s => s.Length);
        }

        static List<string> StringToList(string str)
        {
            return str.Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

      






    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
        private string _searchWord;
        private List<string> _searchList;

        public RepeatCounter (string searchWord, List<string> searchList)
        {
          _searchWord = searchWordWord;
          _searchList = searchList;
        }
        public string GetSearchWord()
        {
          return _searchWord;
        }
        public string GetSearchList()
        {
          return _searchList;
        }
        public void SetSearchWord(string newSearchWord)
        {
          _searchWord = newSearchWord;
        }
        public void SetSearchList(string newSearchList)
        {
          _searchList = newSearchList;
        }
        public static List<RepeatCounter> GetTheList()
        {
          return _searchList;
        }
        public static void ClearAll()
        {
          _searchList.Clear();
        }
        public static string CountRepeats(string matchWord)
        // public static string CountRepeats(string _matchWord, string _inSentence)
        {

          Console.WriteLine(matchWord);
            return matchWord;
        }
  }
}

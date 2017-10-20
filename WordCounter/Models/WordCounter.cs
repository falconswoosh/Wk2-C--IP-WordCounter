using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
        private string _theWord;
        private static List<RepeatCounter> _theSentenceList = new List<RepeatCounter> {};

        public Contacts (string lastName, string firstName, string phoneNumber, string address)
        {
          _theWord = TheWord;
          _theSentenceList.Add(this);
        }
        public string GetTheWord()
        {
          return _theWord;
        }
        public static List<RepeatCounter> GetSentenceList()
        {
          return _theSentenceList;
        }
        public static void ClearAll()
        {
          _theSentenceList.Clear();
        }
        public static string CountRepeats(string theWord, string theSentence)
        {
          if source == target)
          {
            return false;
          }
          else
          {

          }
        }
  }
}

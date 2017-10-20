using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void CountRepeats_IfStringIsReceived_True()
    {
      Assert.AreEqual(var1, Method(input));

      RepeatCounter newWord = new RepeatCounter();
      string result = newWord.CountRepeats("car");
      Console.WriteLine("result: "+result);
      Assert.IsInstanceOfType(result, typeof(string));
    }
  }
}

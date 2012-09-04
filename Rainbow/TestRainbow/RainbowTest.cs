using Rainbow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestRainbow
{
    
    
    /// <summary>
    ///This is a test class for RainbowTest and is intended
    ///to contain all RainbowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RainbowTest
    {
        /// <summary>
        ///Tests for Alphabetise
        ///</summary>
        [TestMethod()]
        public void AlphabetiseTest1()
        {
            List<string> words = new List<string>{"c","b","a"};
            List<string> expected = new List<string> { "a", "b", "c" };
            List<string> actual = StringUtil.Alphabetise(words);
            ListAssertEqual(expected, actual);
     
        }
        [TestMethod()]
        public void AlphabetiseTest2()
        {
            List<string> words = new List<string> { "c", "b", "a","a",null,null };
            List<string> expected = new List<string> { null,null,"a","a", "b", "c" };
            List<string> actual = StringUtil.Alphabetise(words);
            ListAssertEqual(expected, actual);

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AlphabetiseTest3()
        {
            List<string> actual = StringUtil.Alphabetise(null);
        }
        
        private static void ListAssertEqual(List<string> expected, List<string> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < actual.Count; ++i)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}

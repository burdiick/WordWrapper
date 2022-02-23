using NUnit.Framework;
using System;

namespace WordWrapperTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        private void AssertWrapper(String assert, String inputText, int inputLength)
        {
            Assert.AreEqual(assert, WordWrapper.wrap(inputText, inputLength));
        }

        [Test]
        public void givenNull_returnsEmptyString()
        {
            AssertWrapper("", null, 1);
        }

        [Test]
        public void givenBlank_returnEmptyString()
        {
            AssertWrapper("", "", 1);
        }

        [Test]
        public void givenShortWord_returnShortWord()
        {
            AssertWrapper("word", "word", 10);
        }

        [Test]
        public void givenTwoWords_returnTwoLines()
        {
            AssertWrapper("Two\nwords", "Two words" , 5);
        }

        [Test]
        public void givenTwoWords_returnOneLine()
        {
            AssertWrapper("Two words", "Two words", 10);
        }

        [Test]
        public void givenThreeWords_returnTwoLines()
        {
            AssertWrapper("Three word\nsentence", "Three word sentence", 10);
        }

        [Test]
        public void givenLotsOfWords_returnManyLines()
        {
            AssertWrapper("The quick brown fox\njumped over the lazy dog\nand the dog was none the\nwiser",
                "The quick brown fox jumped over the lazy dog and the dog was none the wiser", 25);
        }
    }
}
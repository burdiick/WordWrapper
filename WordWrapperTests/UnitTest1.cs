using NUnit.Framework;

namespace WordWrapperTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void givenNull_returnsEmptyString()
        {
            Assert.AreEqual("", WordWrapper.wrap(null, 1));
        }

        [Test]
        public void givenBlank_returnEmptyString()
        {
            Assert.AreEqual("", WordWrapper.wrap("", 1));
        }

        [Test]
        public void givenShortWord_returnShortWord()
        {
            Assert.AreEqual("word", WordWrapper.wrap("word", 10));
        }

        [Test]
        public void givenTwoWords_returnTwoLines()
        {
            Assert.AreEqual("Two\nwords", WordWrapper.wrap("Two words", 5));
        }

        [Test]
        public void givenTwoWords_returnOneLine()
        {
            Assert.AreEqual("Two words", WordWrapper.wrap("Two words", 10));
        }
    }
}
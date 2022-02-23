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
            Assert.AreEqual("word", WordWrapper.wrap("word", 1));
        }
    }
}
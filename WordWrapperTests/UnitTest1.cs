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
    }
}
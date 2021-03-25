using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class UrlifyTests
    {
        [TestMethod]
        public void UrlifyReturnsCorrectString()
        {
            // Arrange
            var original = "Hello world";
            var expected = "Hello%20world";

            // Act
            var actual = Urlifier.UrlifyWithHelperMethod(original);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [DataRow("Hello world", "Hello%20world")]
        [DataRow("test test test", "test%20test%20test")]
        [TestMethod]
        public void UrlifyCustomReturnsCorrectString(string original, string expected)
        {
            // Arrange

            // Act
            var actual = Urlifier.UrlifyCustom(original);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UrlifyWithStringBuilderReturnsCorrectString()
        {
            // Arrange
            var original = "Hello world";
            var expected = "Hello%20world";

            // Act
            var actual = Urlifier.UrlifyWithStringBuilder(original);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow("Hello world  ", "Hello%20world")]
        [DataRow("test test test    ", "test%20test%20test")]
        [TestMethod]
        public void UrlifyWithCharArrayOnlyReturnsCorrectString(string original, string expected)
        {
            // Arrange

            // Act
            var actual = Urlifier.UrlifyWithCharArrayOnly(original);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

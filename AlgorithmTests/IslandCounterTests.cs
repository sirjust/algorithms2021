using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class IslandCounterTests
    {
        [TestMethod]
        public void IslandCounter_ShouldCountCorrectNumber()
        {
            // Arrange
            var counter = new IslandCounter();
            var map = new int[,]
            {
                 { 0, 0, 1, 0, 1 },
                 { 1, 1, 0, 0, 1 },
                 { 1, 0, 0, 1, 1 },
                 { 0, 0, 1, 0, 0 },
                 { 1, 0, 0, 0, 1 }
            };
            var expected = 6;

            // Act
            var result = counter.CountIslands(map);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IslandCounter_ShouldCountCorrectNumberOnDifferentMap()
        {
            // Arrange
            var counter = new IslandCounter();
            var map = new int[,]
            {
                 { 0, 0, 1, 0, 1 },
                 { 0, 0, 1, 0, 0 },
                 { 1, 1, 0, 0, 1 },
                 { 1, 0, 0, 1, 1 },
                 { 1, 0, 0, 0, 1 }
            };
            var expected = 4;

            // Act
            var result = counter.CountIslands(map);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

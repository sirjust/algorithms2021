using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class SortersTests
    {
        [TestMethod]
        public void MergeSort_ShouldSucceed()
        {
            // Arrange
            var testArray = new[] { 50, 20, -1, 5, -10, 31 };
            var expected = new[] { -10, -1, 5, 20, 31, 50 };

            // Act
            Sorters.MergeSort(testArray, 0, testArray.Length);

            // Assert
            Assert.IsTrue(testArray.SequenceEqual(expected));
        }
    }
}

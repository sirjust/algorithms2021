using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class StringAndArrayAlgorithmsTests
    {
        [TestMethod]
        public void CheckPermutationUsingLinqSucceeds_WhenInputIsPermutation()
        {
            // Arrange
            string original = "hello";
            string input = "ellho";

            // Act
            var result = StringAndArrayAlgorithms.CheckPermutationUsingLinq(original, input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPermutationUsingLinqFails_WhenInputNotPermutation()
        {
            // Arrange
            string original = "hello";
            string input = "ellhoo";

            // Act
            var result = StringAndArrayAlgorithms.CheckPermutationUsingLinq(original, input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPermutationSucceeds_WhenInputIsPermutation()
        {
            // Arrange
            string original = "hello";
            string input = "ellho";

            // Act
            var result = StringAndArrayAlgorithms.CheckPermutation(original, input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPermutationFails_WhenInputNotPermutation()
        {
            // Arrange
            string original = "hello";
            string input = "ellhoo";

            // Act
            var result = StringAndArrayAlgorithms.CheckPermutation(original, input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPermutationFails_WhenOtherInputNotPermutation()
        {
            // Arrange
            string original = "hello";
            string input = "abcde";

            // Act
            var result = StringAndArrayAlgorithms.CheckPermutation(original, input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReverseStringWithStack_Succeeds()
        {
            // Arrange
            var input = new string('a', 5000000);
            var expected = input;

            // Act
            var actual = StringAndArrayAlgorithms.ReverseStringWithStack(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseStringWithStack_Successfully_Reverses()
        {
            // Arrange
            var input = new string("abcde");
            var expected = string.Join("", input.Reverse());

            // Act
            var actual = StringAndArrayAlgorithms.ReverseStringWithStack(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // This one performs better
        [TestMethod]
        public void ReverseStringWithOnlyArray_Succeeds()
        {
            // Arrange
            var input = new string('a', 5000000);
            var expected = input;

            // Act
            var actual = StringAndArrayAlgorithms.ReverseStringWithOnlyArray(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveDuplicatesFromArraySucceedsWithHashSet()
        {
            // Arrange
            var input = new string("The quick brown fox jumped over the lazy dog.");
            var expected = "The quickbrownfxjmpdvtlazyg.";

            // Act
            var actual = StringAndArrayAlgorithms.RemoveDuplicatesFromString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

﻿using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    }
}

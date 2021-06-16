using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Tree_Can_Insert_Values_And_Traverse()
        {
            // Arrange
            Tree tree = new Tree();
            var array = new[] { 25, 20, 15, 27, 30, 29, 26, 22, 32 };
            foreach(var num in array)
            {
                tree.Insert(num);
            }

            // Act
            tree.TraverseInOrder();

            // Assert
            // See console
        }

        [TestMethod]
        public void Tree_Can_Sort()
        {
            // Arrange
            Tree tree = new Tree();
            var numList = new List<int>();
            var num = 8000;
            while (num > -1000)
            {
                numList.Add(num);
                num--;
            }
            foreach (var number in numList)
            {
                tree.Insert(number);
            }

            // Act
            Stopwatch watch = new Stopwatch();
            watch.Start();
            tree.TraverseInOrder();
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsed);
            // Assert
            // See console
        }
    }
}

using Algorithms2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class LinkedListAlorithmsTests
    {
        [TestMethod]
        public void RemoveDuplicatesSucceeds_WhenOneDuplicate()
        {
            // Arrange
            IntegerLinkedList list = new IntegerLinkedList { Head = new IntegerNode(5) };
            list.AddToFront(5);
            list.AddToFront(3);

            // Act
            list.RemoveDuplicates();

            // Assert
            Assert.AreEqual(list.Head.Data, 3);
            Assert.AreEqual(list.Head.Next.Data, 5);
            Assert.IsNull(list.Head.Next.Next);
        }

        [TestMethod]
        public void RemoveDuplicatesSucceeds_WhenMultipleDuplicate()
        {
            // Arrange
            IntegerLinkedList list = new IntegerLinkedList { Head = new IntegerNode(5) };
            list.AddToFront(12);
            list.AddToFront(5);
            list.AddToFront(12);
            list.AddToFront(5);
            list.AddToFront(3);
            list.AddToFront(-6);

            // Act
            list.RemoveDuplicates();

            // Assert
            Assert.AreEqual(-6, list.Head.Data);
            Assert.AreEqual(3, list.Head.Next.Data);
            Assert.AreEqual(5, list.Head.Next.Next.Data);
            Assert.AreEqual(12, list.Head.Next.Next.Next.Data);
            Assert.IsNull(list.Head.Next.Next.Next.Next);
        }

        [TestMethod]
        public void RemoveDuplicatesSucceeds_WhenNoDuplicates()
        {
            // Arrange
            IntegerLinkedList list = new IntegerLinkedList { Head = new IntegerNode(4) };
            list.AddToFront(3);
            list.AddToFront(2);
            list.AddToFront(1);

            // Act
            list.RemoveDuplicates();

            // Assert
            Assert.AreEqual(1, list.Head.Data);
            Assert.AreEqual(2, list.Head.Next.Data);
            Assert.AreEqual(3, list.Head.Next.Next.Data);
            Assert.AreEqual(4, list.Head.Next.Next.Next.Data);
            Assert.IsNull(list.Head.Next.Next.Next.Next);
        }

        [TestMethod]
        public void DeleteDupesFromBookSucceeds_WhenMultipleDuplicates()
        {
            // Arrange
            IntegerLinkedList list = new IntegerLinkedList { Head = new IntegerNode(5) };
            list.AddToFront(12);
            list.AddToFront(5);
            list.AddToFront(12);
            list.AddToFront(5);
            list.AddToFront(3);
            list.AddToFront(-6);

            // Act
            list.DeleteDupesFromBook(list.Head);

            // Assert
            Assert.AreEqual(-6, list.Head.Data);
            Assert.AreEqual(3, list.Head.Next.Data);
            Assert.AreEqual(5, list.Head.Next.Next.Data);
            Assert.AreEqual(12, list.Head.Next.Next.Next.Data);
            Assert.IsNull(list.Head.Next.Next.Next.Next);
        }

        [TestMethod]
        public void GetKthToLast_ReturnsCorrectNode()
        {
            // Arrange
            var list = GetLinkedList();

            // Act
            var node = LinkedListAlgorithms.GetKthToLast(list, 3);

            // Assert
            Assert.AreEqual(30, node.Data);
        }

        [TestMethod]
        public void GetKthToLastFromBook_ReturnsCorrectNode()
        {
            // Arrange
            var list = GetLinkedList();

            // Act
            var node = LinkedListAlgorithms.GetKthToLastFromBook(list, 3);

            // Assert
            Assert.AreEqual(30, node.Data);
        }

        private IntegerLinkedList GetLinkedList()
        {
            var list = new IntegerLinkedList();
            list.AddToFront(10);
            list.AddToFront(20);
            list.AddToFront(30);
            list.AddToFront(40);
            list.AddToFront(50);
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021
{
    public static class LinkedListAlgorithms
    {
        // this is my implementation, and involves iterating twice
        public static IntegerNode GetKthToLast(IntegerLinkedList list, int numberFromLast)
        {
            if (list.Head == null) return null;
            var numberOfNodes = 1;
            var node = list.Head;
            while(node.Next != null)
            {
                numberOfNodes++;
                node = node.Next;
            }

            node = list.Head;
            var numberFromFront = numberOfNodes - numberFromLast;
            if (numberFromFront <= 0) return null;
            while(numberFromFront > 0)
            {
                node = node.Next;
                numberFromFront--;
            }
            return node;
        }

        // this is the book's implementation, and only iterates once
        public static IntegerNode GetKthToLastFromBook(IntegerLinkedList list, int numberFromLast)
        {
            if (list.Head == null) return null;
            IntegerNode p1 = list.Head;
            IntegerNode p2 = list.Head;

            // Move p1 k nodes into the list
            for(int i = 0; i < numberFromLast; i++)
            {
                if (p1 == null) return null;
                p1 = p1.Next;
            }

            // move them at the same pace. When p1 hits the end, p2 will be at the right element
            while(p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p2;
        }
    }

    public class IntegerNode
    {
        public int Data { get; set; }
        public IntegerNode Next { get; set; }

        public IntegerNode(int data)
        {
            Data = data;
        }

        public void SetNext(IntegerNode next)
        {
            Next = next;
        }
    }

    public class IntegerLinkedList
    {
        public IntegerNode Head { get; set; }
        public void AddToFront(int value)
        {
            IntegerNode newNode = new IntegerNode(value);

            newNode.Next = Head;
            Head = newNode;
        }

        public void RemoveDuplicates()
        {
            if (Head == null || Head.Next == null) return;

            var outsideCurrent = Head;
            {
                while(outsideCurrent != null)
                {
                    var current = outsideCurrent.Next;
                    var previous = outsideCurrent;
                    var value = outsideCurrent.Data;
                    while (current != null)
                    {
                        if (current.Data == value)
                        {
                            previous.Next = current.Next;
                        }

                        previous = current;
                        current = current.Next;
                    }
                    outsideCurrent = outsideCurrent.Next;
                }
            }
        }

        // This uses a HashSet and takes only O(n) time
        public void DeleteDupesFromBook(IntegerNode node)
        {
            HashSet<int> set = new HashSet<int>();
            IntegerNode previous = null;
            while (node != null)
            {
                if (set.Contains(node.Data))
                {
                    previous.Next = node.Next;
                }
                else
                {
                    set.Add(node.Data);
                    previous = node;
                }
                node = node.Next;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021
{
    public static class LinkedListAlgorithms
    {
        
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

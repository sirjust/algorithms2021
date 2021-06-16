using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021
{
    public class Tree
    {
        public TreeNode Root { get; set; }

        public void TraverseInOrder()
        {
            Root.TraverseInOrder();
        }

        public void Insert(int value)
        {
            if (Root == null) Root = new TreeNode(value);
            else Root.Insert(value);
        }
    }

    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int data)
        {
            Data = data;
        }

        public void TraverseInOrder()
        {
            if(LeftChild != null)
            {
                LeftChild.TraverseInOrder();
            }
            Console.WriteLine($"Data: {Data}" );
            if(RightChild != null)
            {
                RightChild.TraverseInOrder();
            }
        }

        public void Insert(int value)
        {
            if (value == Data) return;
            if(value < Data)
            {
                if (LeftChild == null) LeftChild = new TreeNode(value);
                LeftChild.Insert(value);
            }
            else
            {
                if (RightChild == null) RightChild = new TreeNode(value);
                RightChild.Insert(value);
            }
        }
    }
}

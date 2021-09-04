using Models;

namespace Algorithms2021
{
    public class TreeTraverser
    {
        public BinaryTree Node { get; set; }
        public void InOrderTraversal(BinaryTree node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Visit(node);
                InOrderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal(BinaryTree node)
        {
            if (node != null)
            {
                Visit(node);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal(BinaryTree node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Visit(node);
            }
        }

        public void Visit(BinaryTree node)
        {
            Node = node;
        }
    }
}

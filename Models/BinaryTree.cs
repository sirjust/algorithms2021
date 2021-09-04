namespace Models
{
    public class BinaryTree : Node<int>
    {
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public new int Data { get; set; }

        public BinaryTree() { }
        public BinaryTree(BinaryTree left, BinaryTree right)
        {
            if (left.Data <= right.Data && left.Data <= Data)
            {
                Left = left;
                Right = right;
            }
            else throw new System.Exception();
        }
    }
}

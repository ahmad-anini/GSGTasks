namespace DataStructure_Task_A
{
    internal class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Value { get; set; }

        public TreeNode(int Value = 0, TreeNode Left = null, TreeNode Right = null)
        {
            this.Left = Left;
            this.Right = Right;
            this.Value = Value;
        }
    }
}

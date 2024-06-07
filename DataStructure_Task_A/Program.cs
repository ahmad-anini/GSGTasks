namespace DataStructure_Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HBBST BST = new HBBST();
            int[] arr = { -10, -3, 0, 5, 9 };
            TreeNode root = BST.sortedArrayToBST(arr, 0, arr.Length - 1);

            printTree(root);
        }

        public static void printTree(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.Value + " ");
            printTree(node.Left);
            printTree(node.Right);
        }




    }

}


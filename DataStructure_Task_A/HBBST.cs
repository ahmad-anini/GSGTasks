namespace DataStructure_Task_A
{
    internal class HBBST
    {

        public TreeNode sortedArrayToBST(int[] arr, int start, int end)
        {

            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(arr[mid]);

            node.Left = sortedArrayToBST(arr, start, mid - 1);

            node.Right = sortedArrayToBST(arr, mid + 1, end);

            return node;
        }
    }
}

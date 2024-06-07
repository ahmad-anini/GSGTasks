namespace GSGTask_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5 };
            int newSize = nums.Length;
            int i = 0;
            while (i < newSize - 1)
            {
                if (nums[i] == nums[i + 1])
                {

                    for (int j = i; j < newSize - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    newSize--;
                }
                else
                {
                    i++;
                }
            }


            Console.Write("[ ");
            for (int k = 0; k < newSize; k++)
            {
                Console.Write($"{nums[k]} ");
            }
            Console.Write("]");
            Console.WriteLine();

            Console.WriteLine($"new Size : {newSize}");
        }
    }
}

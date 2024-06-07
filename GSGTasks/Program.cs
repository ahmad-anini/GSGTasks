namespace GSGTask_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 7, 4, 5, 8, 2, 10, 9 };

            List<int> list = SeenBuildings(arr);


            ////Print The Result

            Console.Write("[ ");
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]");

        }

        static List<int> SeenBuildings(int[] arr)
        {
            List<int> result = new List<int>();
            int max = arr[0];
            result.Add(max);

            if (arr.Length == 1)
            {
                return result;
            }

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > max)
                {
                    result.Add(arr[i]);
                    max = arr[i];
                }
            }

            return result;
        }
    }
}

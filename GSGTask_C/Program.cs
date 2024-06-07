namespace GSGTask_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "I live in Palestine";
            List<string> list = new List<string>(str.Trim().Split(" "));
            list.Reverse();

            foreach (string temp in list)
            {
                Console.Write(temp);
                Console.Write(" ");
            }

        }
    }
}

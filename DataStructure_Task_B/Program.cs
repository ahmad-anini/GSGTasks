namespace DataStructure_Task_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list.ToString());
            Node prev = null, current = list.head, next = null;

            while (current != null)
            {
                next = current.Next;

                current.Next = prev;
                prev = current;
                current = next;
            }
            list.head = prev;
            Console.WriteLine(list.ToString());



        }
    }
}

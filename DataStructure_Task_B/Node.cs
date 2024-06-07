namespace DataStructure_Task_B
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public override string ToString()
        {
            return $"{this.Data}";
        }
    }
}

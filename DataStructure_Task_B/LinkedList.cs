namespace DataStructure_Task_B
{
    public class LinkedList
    {
        public Node head { get; set; }

        public LinkedList()
        {
            this.head = null;
        }

        // Method to add a new node with the specified data at the end of the list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node current = this.head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Method to print all nodes in the list
        public override string ToString()
        {
            Node current = this.head;
            string result = "";
            while (current != null)
            {
                result += $"{current.Data} -> ";
                current = current.Next;
            }
            result += "null";
            return result;
        }
    }
}

namespace Week3;

public class ReverseDoublyLinkedList
{
    public class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode? prev;
        public DoublyLinkedListNode? next;

        public DoublyLinkedListNode(int nodeData)
        {
            data = nodeData;
        }

        public override string ToString()
        {
            var str = $"{data} ";

            var current = next;
            while (current != null)
            {
                str += $"{current.data} ";
                current = current.next;
            }

            return str.Trim();
        }
    }

    public class DoublyLinkedList
    {
        public DoublyLinkedListNode? head;
        public DoublyLinkedListNode? tail;

        public void InsertNode(int nodeData)
        {
            var newNode = new DoublyLinkedListNode(nodeData);

            if (head == null)
            {
                head = newNode;
                return;
            } 

            var current = head;
            while (current.next != null)
                current = current.next;

            current.next = newNode;
            newNode.prev = current;
        }
    }

    public static void Main()
    {
        var llist = new DoublyLinkedList();

        for (var i = 1; i <= 3; i++)
            llist.InsertNode(i);

        var head = Solution(llist.head);

        Console.WriteLine(head!.ToString());
    }

    public static DoublyLinkedListNode? Solution(DoublyLinkedListNode? llist)
    {
        if (llist == null) return null;

        var head = new DoublyLinkedListNode(llist.data);

        while (llist.next != null)
        {
            var next = head;
            head = new DoublyLinkedListNode(llist.next.data) { next = next };
            next.prev = head;

            llist = llist.next;
        }

        return head;
    }
}
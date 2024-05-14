namespace Week3;

public class InsertNodeLinkedList
{

    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode? next;

        public SinglyLinkedListNode(int nodeData)
        {
            data = nodeData;
        }

        public override string ToString()
        {
            var result = "";

            var node = this;
            while (node.next != null)
            {
                result += $"{node.data} ";
                node = node.next;
            }

            result += node.data;

            return result.Trim();
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode? head;

        public void InsertNode(int data)
        {
            var newNode = new SinglyLinkedListNode(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            var current = head;

            while (current.next != null)
                current = current.next;

            current.next = newNode;
        }
    }

    public static void Main()
    {
        var llist = new SinglyLinkedList();
        for (var i = 1; i <=3; i++)
            llist.InsertNode(i);

        var n1 = Solution(llist.head!, 10, 3);

        Console.WriteLine(n1);
    }

    public static SinglyLinkedListNode Solution(SinglyLinkedListNode llist, int data, int position)
    {
        var newList = new SinglyLinkedList();

        var i = 0;
        var current = llist;
        while (current != null)
        {
            if (i == position) newList.InsertNode(data);

            newList.InsertNode(current.data);
            current = current.next;
            i++;
        }

        if (i == position) newList.InsertNode(data);

        return newList.head!;
    }
}
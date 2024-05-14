namespace Week3;

public class ReverseLinkedList
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
        var list = new SinglyLinkedList();

        for (var i = 1; i <= 3; i++)
        {
            list.InsertNode(i);
        }

        var node = Solution2(list.head!);

        Console.WriteLine(node.ToString());
    }

    public static SinglyLinkedListNode Solution(SinglyLinkedListNode llist)
    {
        var stack = new Stack<int>();

        var node = llist;
        stack.Push(node.data);
        while (node.next != null)
        {
            node = node.next;
            stack.Push(node.data);
        }

        var reversed = new SinglyLinkedList();

        while(stack.Any())
            reversed.InsertNode(stack.Pop());

        return reversed.head!;
    }

    public static SinglyLinkedListNode Solution2(SinglyLinkedListNode llist)
    {
        var head = new SinglyLinkedListNode(llist.data);

        while (llist.next != null)
        {
            head = new SinglyLinkedListNode(llist.next.data) { next = head };
            llist = llist.next;
        }

        return head;
    }
}
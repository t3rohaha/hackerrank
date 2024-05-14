namespace Week3;

public class MergeTwoLinkedLists
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
        int[] arr1 = [1, 3, 7];
        var ll1 = new SinglyLinkedList();
        foreach(var n in arr1)
            ll1.InsertNode(n);

        int[] arr2 = [1, 2];
        var ll2 = new SinglyLinkedList();
        foreach(var n in arr2)
            ll2.InsertNode(n);

        var head = Solution(ll1.head, ll2.head);

        Console.WriteLine(head!.ToString());
    }

    public static SinglyLinkedListNode? Solution(SinglyLinkedListNode? head1, SinglyLinkedListNode? head2)
    {
        if (head1 == null) return head2;
        if (head2 == null) return head1;

        var list = new SinglyLinkedList();

        var n1 = head1;
        var n2 = head2;

        while (n1 != null || n2 != null)
        {
            if (n1 != null && n2 != null)
            {
                if (n1.data == n2.data)
                {
                    list.InsertNode(n1.data);
                    list.InsertNode(n2.data);
                    n1 = n1.next;
                    n2 = n2.next;
                    continue;
                }

                if (n1.data < n2.data)
                {
                    list.InsertNode(n1.data);
                    n1 = n1.next;
                    continue;
                }

                if (n1.data > n2.data)
                {
                    list.InsertNode(n2.data);
                    n2 = n2.next;
                    continue;
                }
            }

            if (n1 != null)
            {
                list.InsertNode(n1.data);
                n1 = n1.next;
                continue;
            }

            if (n2 != null)
            {
                list.InsertNode(n2!.data);
                n2 = n2.next;
                continue;
            }
        }

        return list.head;
    }
}
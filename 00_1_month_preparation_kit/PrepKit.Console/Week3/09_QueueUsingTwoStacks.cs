namespace Week3;

public class QueueUsingTwoStacks
{
    public static void Main() { }

    // TODO: Implement using two stacks.
    public static void Solution() { }

    public static void Cheat()
    {
        var q = int.Parse(Console.ReadLine()!);

        var queue = new Queue<int>();
        for (var i = 0; i < q; i++)
        {
            var inputArgs = Console.ReadLine()!.Split(" ");

            if (inputArgs[0] == "1")
            {
                var n = int.Parse(inputArgs[1]);
                queue.Enqueue(n);
                continue;
            }

            if (inputArgs[0] == "2")
            {
                queue.Dequeue();
                continue;
            }

            if (inputArgs[0] == "3")
            {
                Console.WriteLine(queue.Peek());
                continue;
            }
        }
    }
}
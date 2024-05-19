namespace Week4;

public class QHeap
{
    // Cheat
    public static void Main()
    {
        var q = int.Parse(Console.ReadLine()!);

        var heap = new List<int>();

        for (var i = 0; i < q; i++)
        {
            var inputArgs = Console.ReadLine()!
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            if (inputArgs[0] == 1)
            {
                heap.Add(inputArgs[1]);
                continue;
            }

            if (inputArgs[0] == 2)
            {
                heap.Remove(inputArgs[1]);
                continue;
            }

            if (inputArgs[0] == 3)
            {
                Console.WriteLine(heap.Min());
                continue;
            }
        }
    }
}
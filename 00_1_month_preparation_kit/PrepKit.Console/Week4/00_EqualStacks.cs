namespace Week4;

public class EqualStacks
{
    public static void Main()
    {
        Console.WriteLine(Solution([1, 1, 1, 2, 3],
                                   [2, 3, 4],
                                   [1, 4, 1, 1]));
    }

    public static int Solution(List<int> h1, List<int> h2, List<int> h3)
    {
        var h1Size = h1.Sum();
        var h2Size = h2.Sum();
        var h3Size = h3.Sum();

        h1.Reverse();
        h2.Reverse();
        h3.Reverse();

        var h1Stack = new Stack<int>(h1);
        var h2Stack = new Stack<int>(h2);
        var h3Stack = new Stack<int>(h3);


        var minSize = new int[] { h1Size, h2Size, h3Size }.Min();

        while (h1Size != h2Size || h1Size != h3Size)
        {
            while (h1Size > minSize)
                h1Size -= h1Stack.Pop();

            while (h2Size > minSize)
                h2Size -= h2Stack.Pop();

            while (h3Size > minSize)
                h3Size -= h3Stack.Pop();

            if (h1Size < minSize) minSize = h1Size;
            if (h2Size < minSize) minSize = h2Size;
            if (h3Size < minSize) minSize = h3Size;
        }

        return minSize;
    }
}
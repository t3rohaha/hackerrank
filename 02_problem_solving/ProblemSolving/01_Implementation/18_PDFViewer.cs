namespace Implementation;

public class PDFViewer
{
    public static void Main()
    {
        var a = Solution([1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 1, 1, 5, 5, 1, 5, 2, 5, 5, 5, 5, 5, 5], "torn");
        Console.WriteLine(a);

        var b = Solution([1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5], "abc");
        Console.WriteLine(b);

        var c = Solution([1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7], "zaba");
        Console.WriteLine(c);
    }

    public static int Solution(List<int> h, string word)
    {
        var max = 0;
        foreach (var c in word)
            if (max < h[c - 97])
                max = h[c-97];

        return max * word.Length;
    }
}
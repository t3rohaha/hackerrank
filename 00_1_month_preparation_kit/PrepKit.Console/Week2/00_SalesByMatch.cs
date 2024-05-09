namespace SalesByMatch;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(SockMerchant([1, 2, 1, 2, 1, 3, 2]));
        Console.WriteLine(SockMerchant([10, 20, 20, 10, 10, 30, 50, 10, 20]));
    }

    static int SockMerchant(int[] ar)
    {
        var socks = ar.GroupBy(x => x);
        int pairs = 0;

        foreach (var s in socks)
            pairs += s.Count() / 2;

        return pairs;
    }
}
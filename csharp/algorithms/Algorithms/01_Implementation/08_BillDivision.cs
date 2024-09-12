namespace Implementation;

public class BillDivision
{
    public static void Main()
    {
        Solution([3, 10, 2, 9], 1, 12);
    }

    public static void Solution(List<int> bill, int k, int b)
    {
        bill.RemoveAt(k);

        var sum = 0;
        foreach (var n in bill)
            sum += n;
        sum /= 2;

        if (sum == b) Console.WriteLine("Bon Appetit");
        else Console.WriteLine($"{b - sum}");
    }
}
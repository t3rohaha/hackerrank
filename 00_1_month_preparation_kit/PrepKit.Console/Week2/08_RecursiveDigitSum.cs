namespace Week2;

public class RecursiveDigitSum
{
    public static void Main()
    {
        Console.WriteLine(Solution("9875", 4));
        Console.WriteLine(Solution("148", 3));
    }

    static int Solution(string n, int k)
    {
        // 'n' will always become single digit.
        if (n.Length == 1)
        {
            return int.Parse(n);
        }

        // Sum the digits in 'n'.
        decimal sum = 0;
        foreach (var c in n)
        {
            sum += c - '0';
        }

        // Multiply 'sum' by 'k' only when method is called initially.
        // Otherwise multiply by 1, which does not change the sum.
        sum *= k;

        return Solution(sum.ToString(), 1);
    }
}
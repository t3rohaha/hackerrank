namespace Implementation;

public class BeautifulDaysAtTheMovies
{
    public static void Main()
    {
        Console.WriteLine(Solution(20, 23, 6));
    }

    public static int Solution(int i, int j, int k)
    {
        var reverse = (int n) =>
        {
            var reversed = string.Join("", n.ToString().Reverse());
            return int.Parse(reversed);
        };

        var count = 0;
        for (var y = i; y <= j; y++)
            if (Math.Abs(y - reverse(y)) % k == 0)
                count++;

        return count;
    }
}
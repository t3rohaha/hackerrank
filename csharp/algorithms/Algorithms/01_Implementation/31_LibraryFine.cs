namespace Implementation;

public class LibraryFine
{
    public static void Main()
    {
        Console.WriteLine(Solution(14, 7, 2018, 5, 7, 2018));
        Console.WriteLine(Solution(9, 6, 2015, 6, 6, 2015));
    }

    public static int Solution(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        var actual = new DateTime(y1, m1, d1);
        var expected = new DateTime(y2, m2, d2);

        var fine = 0;
        if (expected < actual)
        {
            if (expected.Year < actual.Year)
                fine = 10_000;
            else if (expected.Month < actual.Month)
                fine = 500 * (actual.Month - expected.Month);
            else
                fine = 15 * (actual.Day - expected.Day);
        }

        return fine;
    }
}
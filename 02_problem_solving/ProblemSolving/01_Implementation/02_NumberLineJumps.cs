namespace Implementation;

public class NumberLineJumps
{
    public static void Main()
    {
        Console.WriteLine(Solution(2, 1, 1, 2));
    }

    public static string Solution(int x1, int v1, int x2, int v2)
    {
        if (x1 == x2 && v1 == v2) return "YES";

        if (x1 > x2 && v1 < v2)
        {
            while (true)
            {
                x1 += v1;
                x2 += v2;

                if (x1 < x2) break;
                if (x1 == x2) return "YES";
            }
        }

        if (x1 < x2 && v1 > v2)
        {
            while (true)
            {
                x1 += v1;
                x2 += v2;

                if (x1 > x2) break;
                if (x1 == x2) return "YES";
            }
        }

        return "NO";
    }
}
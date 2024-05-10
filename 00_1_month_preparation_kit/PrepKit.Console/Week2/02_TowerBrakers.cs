namespace Week2;

public class TowerBrakers
{
    public static void Main()
    {
        Console.WriteLine(Solution(2, 6));
        Console.WriteLine(Solution(2, 1));
        Console.WriteLine(Solution(1, 6));
    }

    /*
        n - Number of towers.
        m = Height of each tower.
    */
    static int Solution(int n, int m)
    {
        var condition1 = m == 1;        // P1 has no moves, P2 always wins.
        var condition2 = n % 2 == 0;    // P1 starts first, P2 always wins.

        return condition1 || condition2 ? 2 : 1;
    }
}
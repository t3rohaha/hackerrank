namespace Week2;

public class DrawingBook
{
    public static void Main()
    {
        Console.WriteLine(Solution(5, 3));
        Console.WriteLine(Solution(5, 4));
    }

    /*
        n -> number of pages.
        p -> requested page.
        returns int -> minimum number of pages to turn.

        0, 1 => 2, 3 => 4, 5 => 6, 7 => 8, 9 => 10, 11

        n = 1 totalPages = 1 / 2 = 0
        n = 2 totalPages = 2 / 2 = 1
        n = 3 totalPages = 3 / 2 = 1
        n = 4 totalPages = 4 / 2 = 2
        n = 5 totalPages = 5 / 2 = 2

        p = 1 requestedPage = 1 / 2 = 0
        p = 2 requestedPage = 2 / 2 = 1
        p = 3 requestedPage = 3 / 2 = 1
        p = 4 requestedPage = 4 / 2 = 2
        p = 5 requestedPage = 5 / 2 = 2

        lr = rp
        rl = tp - rp
    */
    static int Solution(int n, int p)
    {
        var totalPages = n / 2;
        var requestedPage = p / 2;
        var lr = requestedPage;
        var rl = totalPages - requestedPage;

        return lr < rl ? lr : rl;
    }
}
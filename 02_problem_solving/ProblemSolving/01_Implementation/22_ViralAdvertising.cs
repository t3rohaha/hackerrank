namespace Implementation;

public class ViralAdvertising
{
    public static void Main()
    {
        Console.WriteLine(Solution(3));
    }

    public static int Solution(int n)
    {
        var day = 1;
        var shared = 5;
        var liked = shared / 2;
        var cumulative = liked;

        while (day != n)
        {
            shared = liked * 3;
            liked = shared / 2;
            cumulative += liked;
            day++;
        }

        return cumulative;
    }
}
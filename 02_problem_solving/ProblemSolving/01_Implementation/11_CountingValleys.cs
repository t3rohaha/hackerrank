namespace Implementation;

public class CountingValleys
{
    public static void Main()
    {
        Console.WriteLine(Solution(0, "DDUUUUDD"));
    }

    public static int Solution(int steps, string path)
    {
        var altitude = 0;
        var counter = 0;

        foreach (var p in path)
        {
            if (altitude == 0 && p == 'D')
                counter++;

            if (p == 'U') altitude++;
            else if (p == 'D') altitude--;
        }

        return counter;
    }
}
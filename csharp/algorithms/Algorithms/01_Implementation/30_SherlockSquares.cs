namespace Implementation;

public class SherlockSquares
{
    public static void Main()
    {
        Console.WriteLine(Solution(0, 9));
    }

    public static int Solution(int a, int b)
    {
        var x = Math.Sqrt(a);
        var y = Math.Sqrt(b);

        if (double.IsInteger(x)) x--;

        return (int)y - (int)x;
    }
}
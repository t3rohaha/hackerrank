namespace Implementation;

public class CatsAndMouse
{
    public static void Main()
    {
        Console.WriteLine(Solution(1, 2, 3));
        Console.WriteLine(Solution(1, 3, 2));
    }

    public static string Solution(int x, int y, int z)
    {
        var a =  Math.Abs(x-z);
        var b = Math.Abs(y-z);

        if (a < b) return "Cat A";
        if (a > b) return "Cat B";
        return "Mouse C";
    }
}
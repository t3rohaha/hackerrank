namespace Strings;

public class StrongPassword
{
    public static void Main()
    {
        Console.WriteLine(Solution(5, "2bbbb"));
        Console.WriteLine(Solution(5, "2bb#A"));
        Console.WriteLine(Solution(3, "Ab1"));
    }

    public static int Solution(int n, string password)
    {
        var numbers = "0123456789";
        var lower = "abcdefghijklmnopqrstuvwxyz";
        var upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var special = "!@#$%^&*()-+";
        var count = 0;

        if (!numbers.Any(x => password.Contains(x)))
            count++;
        if (!lower.Any(x => password.Contains(x)))
            count++;
        if (!upper.Any(x => password.Contains(x)))
            count++;
        if (!special.Any(x => password.Contains(x)))
            count++;

        if (password.Length + count < 6)
            return 6 - password.Length;
        else
            return count;
    }
}
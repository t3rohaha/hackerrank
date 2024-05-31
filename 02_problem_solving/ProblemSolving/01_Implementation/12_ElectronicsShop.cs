namespace Implementation;

public class ElectronicsShop
{
    public static void Main()
    {
        Console.WriteLine(Solution([40, 50, 60], [5, 8, 12], 60));
        Console.WriteLine(Solution([3, 1], [5, 2, 8], 10));
    }

    public static int Solution(int[] keyboards, int[] drives, int b)
    {
        var choice = -1;

        for (var i = 0; i < keyboards.Count(); i++)
        {
            for (var y = 0; y < drives.Count(); y++)
            {
                var sum = keyboards[i] + drives[y];
                if (sum <= b && sum > choice)
                    choice = sum;
            }
        }

        return choice;
    }
}
namespace Greedy;

public class MarksCakewalk
{
    public static void Main()
    {
        Console.WriteLine(Solution([7, 4, 9, 6]));
    }

    public static long Solution(List<int> calorie)
    {
        var cupcakes = calorie.OrderByDescending(x => x).ToArray();

        long minimumMilesToBurnCals = 0;

        for (var i = 0; i < cupcakes.Length; i++)
            minimumMilesToBurnCals += (long)(Math.Pow(2, i) * cupcakes[i]);

        return minimumMilesToBurnCals;
    }
}
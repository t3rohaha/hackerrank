namespace Week3;

public class TruckTour
{
    public static void Main()
    {
        Console.WriteLine(Solution([[1, 5], [10, 3], [3, 4]]));
    }

    public static int Solution(List<List<int>> petrolpumps)
    {
        for (var i = 0; i < petrolpumps.Count; i++)
            if (IsValidRoute(i, petrolpumps)) return i;

        return 0;
    }

    public static bool IsValidRoute(int start, List<List<int>> pp)
    {
        var tank = 0;

        for (var i = start; i < pp.Count; i++)
        {
            tank += pp[i][0];
            tank -= pp[i][1];

            if (tank < 0) return false;
        }


        for (var i = 0; i < start; i++)
        {
            tank += pp[i][0];
            tank -= pp[i][1];

            if (tank < 0) return false;
        }

        return true;
    }
}
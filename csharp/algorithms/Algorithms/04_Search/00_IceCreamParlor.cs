namespace Search;

public class IceCreamParlor
{
    public static void Main()
    {
        var r1 = Solution(4, [1, 4, 5, 3, 2]);
        Console.WriteLine(string.Join(", ", r1));

        var r2 = Solution(4, [2, 2, 4, 3]);
        Console.WriteLine(string.Join(", ", r2));
    }

    public static List<int> Solution(int m, List<int> arr)
    {
        for (var i = 0; i < arr.Count; i++)
            for (var y = i+1; y < arr.Count; y++)
                if (arr[i] + arr[y] == m) 
                    return [i+1, y+1];

        return [];
    }
}
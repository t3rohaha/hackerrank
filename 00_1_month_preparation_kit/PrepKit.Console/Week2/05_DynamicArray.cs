namespace DynamicArray;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\n" ,DynamicArray(2, [[1, 0, 5],
                                                             [1, 1, 7],
                                                             [1, 0, 3],
                                                             [2, 1, 0],
                                                             [2, 1, 1]])));
    }

    static List<int> DynamicArray(int n, int[][] queries)
    {
        var arr2D = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            arr2D[i] = new List<int>();
        }

        var answers = new List<int>();
        var lastAnswer = 0;

        foreach(var query in queries)
        {
            int q = query[0];
            int x = query[1];
            int y = query[2];
            int idx = (x^lastAnswer) % n;

            if (q == 1)
            {
                arr2D[idx].Add(y);
            }
            else
            {
                var wtfIdx = y % arr2D[idx].Count;
                lastAnswer = arr2D[idx][wtfIdx];
                answers.Add(lastAnswer);
            }
        }

        return answers;
    }
}
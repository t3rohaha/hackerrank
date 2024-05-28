namespace Implementation;

public class GradingStudents
{
    public static void Main()
    {
        var results = Solution([73, 67, 38, 33]);
        foreach (var r in results)
        {
            Console.WriteLine(r);
        }
    }

    public static List<int> Solution(List<int> grades)
    {
        var results = new List<int>(grades.Count);

        foreach (var n in grades)
        {
            var rem = n % 5;

            if (n < 38 || rem == 0 || rem < 3)
                results.Add(n);
            else
                results.Add(n + (5-rem));
        }

        return results;
    }
}
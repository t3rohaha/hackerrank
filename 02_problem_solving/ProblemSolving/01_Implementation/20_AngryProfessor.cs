namespace Implementation;

public class AngryProfessor
{
    public static void Main()
    {
        Console.WriteLine(Solution(1, [0, -1]));
    }

    public static string Solution(int k, List<int> a)
    {
        var students = 0;

        foreach (var s in a)
        {
            if (s <= 0)
            {
                students++;
                if (students == k)
                    return "NO";
            }
        }

        return "YES";
    }
}
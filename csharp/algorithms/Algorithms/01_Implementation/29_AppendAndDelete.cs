namespace Implementation;

public class AppendAndDelete
{
    public static void Main()
    {
        Solution("abc", "def", 6);
        Solution("hackerhappy", "hackerrank", 9);
    }

    // TODO: The operations should be exactly k.
    // Not completed.
    public static string Solution(string s, string t, int k)
    {
        var q1 = new Queue<char>(s);
        var q2 = new Queue<char>(t);

        while (q1.Any() && q2.Any())
        {
            if (q1.Peek() == q2.Peek())
            {
                q1.Dequeue();
                q2.Dequeue();
            }
            else break;
        }

        if (q1.Count + q2.Count <= k)
            return "Yes";

        return "No";
    }
}
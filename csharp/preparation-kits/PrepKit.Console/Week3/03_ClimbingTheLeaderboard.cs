namespace Week3;

public class ClimbingTheLeaderboard
{
    public static void Main() { }

    public static List<int> Solution(List<int> ranked, List<int> player)
    {
        var leaderboard = new Stack<int>(new HashSet<int>(ranked));
        var results = new List<int>(player.Count);
        var pos = leaderboard.Count+1;

        foreach (var s in player)
        {
            while (leaderboard.Any())
            {
                var l = leaderboard.Peek();
                if (s >= l)
                {
                    pos--;
                    leaderboard.Pop();
                }
                else break;
            }

            results.Add(pos);
        }

        return results;
    }
}
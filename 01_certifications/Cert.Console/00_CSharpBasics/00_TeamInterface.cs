namespace CSharpBasics;

public class TeamInterface
{
    public static void Main() { }

    public class Team
    {
        public string teamName;
        public int noOfPlayers;

        public Team(string name, int count)
        {
            teamName = name;
            noOfPlayers = count;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            if (noOfPlayers - count < 0)
                return false;

            noOfPlayers -= count;

            return true;
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers)
            : base(teamName, noOfPlayers) { }

        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
    }
}
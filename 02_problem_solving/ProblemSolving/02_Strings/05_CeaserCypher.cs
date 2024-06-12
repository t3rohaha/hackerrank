namespace Strings;

public class CeaserCypher
{
    public static void Main()
    {
        Solution("abcdefghijklmnopqrstuvwxyz", 2);
    }

    public static string Solution(string s, int k)
    {
        var alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        var alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        var alphabetLowerRotated = new char[alphabetLower.Length];
        for (var i = 0; i < 26; i++)
            alphabetLowerRotated[(i+k) % 26] = alphabetLower[i];

        var alphabetUpperRotated = new char[alphabetLower.Length];
        for (var i = 0; i < 26; i++)
            alphabetUpperRotated[(i+k) % 26] = alphabetUpper[i];

        var output = new List<char>(s.Length);
        foreach (var c in s)
        {
            if (char.IsAsciiLetterLower(c))
            {
                var idx = Array.IndexOf(alphabetLowerRotated, c);
                output.Add(alphabetLower[Array.IndexOf(alphabetLowerRotated, c)]);
            }
            else if (char.IsAsciiLetterUpper(c))
                output.Add(alphabetUpper[Array.IndexOf(alphabetUpperRotated, c)]);
            else
                output.Add(c);
        }

        return string.Join("", output);
    }

    public static string Solution2(string s, int k)
    {
        var output = "";
        var alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

        foreach (var c in s)
        {
            var idx = Array.IndexOf(alphabet, char.ToLower(c));

            if (idx == -1) output += c;
            else
            {
                var cypher = alphabet[(idx+k) % 26];
                if (char.IsAsciiLetterUpper(c)) cypher = char.ToUpper(cypher);
                output += cypher;
            }
        }

        return output;
    }
}
namespace CeaserCipher;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(CeaserCipher("middle-Outz", 2));
    }

    /*
        s -> Text.
        k -> Alphabet rotation factor.
    */
    static string CeaserCipher(string s, int k)
    {
        var encryptedStr = "";
        var alphabet = "abcdefghijklmnopqrstuvwxyz";

        foreach (var c in s)
        {
            if (char.IsAsciiLetter(c))
            {
                var i = alphabet.IndexOf(char.ToLower(c));
                var effectiveIndex = (k + i) % 26;
                var encryptedChar = alphabet[effectiveIndex];

                if (char.IsAsciiLetterUpper(c))
                {
                    encryptedStr += char.ToUpper(encryptedChar);
                }
                else
                {
                    encryptedStr += encryptedChar;
                }
            }
            else
            {
                encryptedStr += c;
            }
        }

        return encryptedStr;
    }
}
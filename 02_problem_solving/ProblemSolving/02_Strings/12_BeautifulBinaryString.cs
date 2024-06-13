namespace Strings;

public class BeautifulBinaryString
{
    public static void Main()
    {
        Console.WriteLine(Solution("0101010"));
        Console.WriteLine(Solution("01100"));
        Console.WriteLine(Solution("0100101010"));
    }

    public static int Solution(string b)
    {
        var bArr = new char[b.Length];
        for (var i = 0; i < b.Length; i++)
            bArr[i] = b[i];

        var count = 0;
        for (var i = 0; i < b.Length - 2; i++)
        {
            var p1 = bArr[i];
            var p2 = bArr[i+1];
            var p3 = bArr[i+2];

            if (p1 == '0' && p2 == '1' && p3 == '0')
            {
                bArr[i+2] = '1';
                count++;
            }
        }

        return count;
    }
}
namespace Week2;

public class PalindromeIndex
{
    public static void Main() { }

    public static int Solution(string s)
    {
        var arr = s.ToList();
        var rev = s.Reverse().ToList();

        if (arr.SequenceEqual(rev)) return -1;

        var start = 0;
        var end = s.Length - 1; 
        for (var i = 0; i < s.Length; i++)
        {
            var c1 = arr[i];
            var c2 = rev[i];

            if (c1 != c2)
            {
                var temp = rev[end-i];
                arr.RemoveAt(start+i);
                rev.RemoveAt(end-i);

                if (arr.SequenceEqual(rev)) return i;

                arr.Insert(start+i, c1);
                rev.Insert(end-i, temp);

                arr.RemoveAt(end-i);
                rev.RemoveAt(start+i);

                if (arr.SequenceEqual(rev)) return end-i;

                break;
            }
        }

        return -1;
    }
}
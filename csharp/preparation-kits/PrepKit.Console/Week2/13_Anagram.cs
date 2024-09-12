namespace Week2;

public class Anagram
{
    public static void Main()
    {
        Solution("fdhlvosfpafhalll");
    }

    public static int Solution2(string s)
    {
        if (s.Length % 2 != 0) return -1;

        var a = s.Substring(0, s.Length / 2);
        var b = s.Substring(s.Length / 2);

        if (a == b) return 0;

        foreach (var c in b)
            if (a.IndexOf(c) != -1)
                a = a.Remove(a.IndexOf(c), 1);

        return a.Length;
    }

    public static int Solution(string s)
    {
        if (s.Length % 2 != 0) return -1;

        // Split string to char arrays with equal length.
        var arr = s.ToCharArray();
        var leftHalf = new char[s.Length / 2];
        var rightHalf = new char[s.Length / 2];

        for (var i = 0; i < arr.Length / 2; i++)
        {
            leftHalf[i] = arr[i];
            rightHalf[i] = arr[arr.Length / 2 + i];
        }

        // Transfrom arrays to group of symbols and order alphabetically.
        var leftGroup = leftHalf
        .GroupBy(c => c)
        .Select(g => new SymbolCount { Symbol = g.Key, Count = g.Count() }) 
        .OrderBy(x => x.Symbol)
        .ToList();
        var rightGroup = rightHalf
        .GroupBy(c => c)
        .Select(g => new SymbolCount { Symbol = g.Key, Count = g.Count() }) 
        .OrderBy(x => x.Symbol)
        .ToList();

        // Reduce the count of equal symbols.
        var copy = new List<SymbolCount>(leftGroup);
        foreach (var c in copy)
        {
            var l = leftGroup.FirstOrDefault(x => c.Symbol == x.Symbol)!;
            var r = rightGroup.FirstOrDefault(g => l.Symbol == g.Symbol);
            if (r == null) continue;

            if (l.Count == r.Count)
            {
                leftGroup.Remove(l);
                rightGroup.Remove(r);
                continue;
            }

            if (l.Count > r.Count)
            {
                l.Count -= r.Count;
                rightGroup.Remove(r);
                continue;
            }

            if (l.Count < r.Count)
            {
                r.Count -= l.Count;
                leftGroup.Remove(l);
                continue;
            }
        }

        // Groups are already equal.
        if (leftGroup.Count == 0)
            return 0;

        // Only different characters left.
        return leftGroup.Sum(l => l.Count);
    }

    class SymbolCount
    {
        public char Symbol { get; set; }
        public int Count { get; set; }
    }
}
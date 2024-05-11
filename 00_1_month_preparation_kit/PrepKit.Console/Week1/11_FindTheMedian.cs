namespace Week1;

public class FindTheMedian
{
    public static void Main()
    {
        Solution([3, 1, 2]);
    }

    public static int Solution(List<int> arr)
    {
        arr.Sort();
        return arr[arr.Count / 2];
    }
}
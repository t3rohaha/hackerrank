namespace Sorting;

public class InsertionSort2
{
    public static void Main()
    {
        Solution(7, [3, 4, 7, 5, 6, 2, 1]);
    }

    public static void Solution(int n, List<int> arr)
    {
        for (var i = 1; i < n; i++)
        {
            var key = arr[i];
            var j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = key;

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
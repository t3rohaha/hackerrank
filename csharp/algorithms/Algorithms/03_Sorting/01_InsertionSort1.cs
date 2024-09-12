namespace Sorting;

public class InsertionSort1
{
    public static void Main()
    {
        Solution2(5, [2, 4, 6, 8, 3]);
    }

    public static void Solution(int n, List<int> arr)
    {
        var e = arr[n - 1];
        var printArray = (List<int> arr) => 
        {
            Console.WriteLine(string.Join(" ", arr));
        };

        for (var i = n - 2; i > -1; i--)
        {
            if (arr[i] > e)
            {
                arr[i + 1] = arr[i];
                printArray(arr);
                if (i == 0) arr[i] = e;
            }
            else
            {
                arr[i + 1] = e;
                break;
            }
        }
        
        printArray(arr);
    }

    public static void Solution2(int n, List<int> arr)
    {
        var printArray = (List<int> arr) => 
        {
            Console.WriteLine(string.Join(" ", arr));
        };

        var key = arr[n-1];
        var i = n - 2;

        while (i >= 0 && arr[i] > key)
        {
            arr[i+1] = arr[i];
            i--;
            printArray(arr);
        }

        arr[i+1] = key;
        printArray(arr);
    }
}
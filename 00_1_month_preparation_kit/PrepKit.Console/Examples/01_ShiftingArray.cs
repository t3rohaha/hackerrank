namespace ShiftingArray;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(" ", Shift([1, 2, 3, 4], -2)));
    }

    static int[] Shift(int[] arr, int k)
    {
        var size = arr.Length;
        var newArr = new int[size];

        if (k >= 0) // Shift right
        {
            for (int i = 0; i < size; i++)
            {
                var idx = (i+k) % size;
                newArr[idx] = arr[i];
            }
        }
        else        // Shift left
        {
            k = Math.Abs(k);
            for (int i = 0; i < size; i++)
            {
                var idx = (i+Math.Abs(k)) % size;
                newArr[i] = arr[idx];
            }
        }

        return newArr;
    }
}

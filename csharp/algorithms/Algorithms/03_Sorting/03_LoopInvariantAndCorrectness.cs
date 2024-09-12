namespace Sorting;

public class LoopInvariantAndCorrectness
{
    public static void Main()
    {
        Solution([7, 4, 3, 5, 6, 2]);
    }

    public static void Solution(int[] A)
    {
        for (var i = 1; i < A.Length; i++)
        {
            var value = A[i]; 
            var j = i - 1; 
            while (j >= 0 && value < A[j])
            {
                A[j + 1] = A[j];
                j--; 
            } 
            A[j + 1] = value; 
        } 

        Console.WriteLine(string.Join(" ", A));  
    }
}
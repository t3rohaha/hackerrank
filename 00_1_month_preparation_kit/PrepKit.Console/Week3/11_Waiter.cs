namespace Week3;

public class Waiter
{
    public static void Main()
    {
        Solution([3, 4, 7, 6, 5], 1);
    }

    public static List<int> Solution(List<int> number, int q)
    {
        var numbersToCheck = new Stack<int>(number);
        var answers = new List<int>(number.Count);
        var primes = GetPrimes(q);

        for (var i = 0; i < q; i++)
        {
            var queue = new Queue<int>();
            var stack = new Stack<int>();

            while (numbersToCheck.Any())
            {
                var current = numbersToCheck.Pop();

                if (current % primes[i] != 0)
                    queue.Enqueue(current);
                else
                    stack.Push(current);
            }

            while (stack.Any())
                answers.Add(stack.Pop());

            while (queue.Any())
                numbersToCheck.Push(queue.Dequeue());
        }

        while (numbersToCheck.Any())
            answers.Add(numbersToCheck.Pop());

        return answers;
    }

    public static List<int> GetPrimes(int count)
    {
        var primes = new List<int>(count);

        var i = 2;
        while (primes.Count != count)
        {
            if (IsPrime(i))
                primes.Add(i);
            i++;
        }

        return primes;
    }

    public static bool IsPrime(int n)
    {
        if (n == 2) return true;

        for (int i = 2; i < n; i++)
            if (n % i == 0) return false;

        return true;
    }
}
namespace Week3;

public class SimpleTextEditor
{
    public static void Main()
    {
        var cmdCount = int.Parse(Console.ReadLine()!);

        var stack = new Stack<string>();

        for (var i = 0; i < cmdCount; i++)
        {
            var cmdArgs = Console.ReadLine()!.Split(" ");

            if (cmdArgs[0] == "1")
            {
                var append = cmdArgs[1];
                var str = "";
                if (stack.Any())
                    str = stack.Peek();
                str += append;
                stack.Push(str);
                continue;
            }

            if (cmdArgs[0] == "2")
            {
                var deleteCount = int.Parse(cmdArgs[1]);
                var str = stack.Peek();
                var newStr = str.Remove(str.Length - deleteCount);
                stack.Push(newStr);
                continue;
            }

            if (cmdArgs[0] == "3")
            {
                var printAt = int.Parse(cmdArgs[1]);
                Console.WriteLine(stack.Peek()[printAt-1]);
                continue;
            }

            if (cmdArgs[0] == "4")
            {
                stack.Pop();
                continue;
            }
        }
    }
}
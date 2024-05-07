namespace BitwiseOperators;

public class Program
{
    public static void Main()
    {
        BitwiseComplementExample();
        LeftShiftExample();
        RightShiftExample();
        UnsignedRightShiftExample();
    }

    static void BitwiseComplementExample()
    {
        uint before = 0b_1111_0000_1111_0000_1111_0000_1111_0000;
        uint after = ~before;
        WriteOutput("Bitwise Complement", before, after);
    }

    static void LeftShiftExample()
    {
        uint before = 0b_1111_0000_1111_0000_1111_0000_1111_0000;
        uint after = before << 1;
        WriteOutput("Left Shift", before, after);
    }

    static void RightShiftExample()
    {
        uint before = 0b_1111_0000_1111_0000_1111_0000_1111_0000;
        uint after = before >> 1;
        WriteOutput("Right Shift", before, after);
    }

    static void UnsignedRightShiftExample()
    {
        uint before = 0b_1111_0000_1111_0000_1111_0000_1111_0000;
        uint after = before >>> 1;
        WriteOutput("Unsigned Right Shift", before, after);
    }

    static void WriteOutput(string title, uint before, uint after)
    {
        Console.WriteLine($"{title}:");
        Console.WriteLine($"Before: {Convert.ToString(before, toBase: 2), 32}");
        Console.WriteLine($"After:  {Convert.ToString(after, toBase: 2), 32}");
    }
}
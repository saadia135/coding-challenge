using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unsigned integral type:");
        Console.WriteLine($"byte  : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint  : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

        Console.WriteLine("\nFloating-point type:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");

        Console.WriteLine("\nSize of types in bytes:");
        Console.WriteLine($"byte   : {sizeof(byte)} bytes");
        Console.WriteLine($"ushort : {sizeof(ushort)} bytes");
        Console.WriteLine($"uint   : {sizeof(uint)} bytes");
        Console.WriteLine($"ulong  : {sizeof(ulong)} bytes");
        Console.WriteLine($"float  : {sizeof(float)} bytes");
        Console.WriteLine($"double : {sizeof(double)} bytes");
    }
}


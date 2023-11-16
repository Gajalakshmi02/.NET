using System;
using System.Runtime.InteropServices;
class DataTypes 
{
    static void Main()
    {
        int i = 24;
        long myNum = 9000000000;
        Console.WriteLine("Int: " + int.MinValue + ", " + int.MaxValue);
        Console.WriteLine("my Long number is : " + myNum);

        float f = 3.14f;
        double d = 36.141592653;
        decimal myDecimal = 123.456m;
        Console.WriteLine("my Float value is : " + f);
        Console.WriteLine("my Double num is : " + d);
        Console.WriteLine("my Decimal point is : " + myDecimal);

        char c = 'A';
        string myName = "Hello, Gajalakshmi...!";
        Console.WriteLine("Char: " + c);
        Console.WriteLine("String: " + myName);

        bool boo = true;
        bool bo = false;
        Console.WriteLine(boo);
        Console.WriteLine(bo);
    }
}

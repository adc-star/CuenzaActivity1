using System;

class Program
{
    static int Add(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        int result = Add(num1, num2, num3, num4);
        Console.WriteLine("Total: " + result);
    }
}

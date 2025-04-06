using System;

class Program
{
    static int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int result = Subtract(num1, num2, num3);
        Console.WriteLine("Result: " + result);
    }
}

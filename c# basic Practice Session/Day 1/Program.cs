using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
class Sum
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter first Number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int Sum = num1 + num2;
        Console.WriteLine("The sum of Two numbers are"+ Sum);

    }
}

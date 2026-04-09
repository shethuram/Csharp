using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input! Please enter a non-negative integer.");
            return;
        }

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is {factorial}");
    }
}
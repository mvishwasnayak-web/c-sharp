using System;

class Geeks
{
    static void Main()
    {
        int[] num = { 8, 17, 24, 5 };
        int[] divisors = { 2, 0, 5 };


        try
        {
            for (int i = 0; i < num.Length; i++)
            {

                try
                {
                    Console.WriteLine($"Number: {num[i]}, Divisor: {divisors[i]}");
                    Console.WriteLine($"Quotient: {num[i] / divisors[i]}");
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Inner Try Catch Block: Division by zero error.");
                }
            }
        }

        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Outer Try Catch Block: Index out of range error.");
        }
        Console.ReadLine();
    }
}

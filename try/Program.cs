using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("The result is: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("An unexpected error occurred: ");
        }
        finally
        {
            Console.WriteLine("End of the program:");
        }
        Console.ReadLine();
    }
}

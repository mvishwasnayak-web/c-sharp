using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter a divisor");
        int divisor = Convert.ToInt32(Console.ReadLine());  
        try
        {
            try
            {
                int result = 10 / divisor;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("inner catch is executed:" + e.Message);
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("outer catch is executed:" + e.Message);
        }
        Console.ReadLine();
    }
}



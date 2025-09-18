using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num != 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
        Console.WriteLine(sum);
        Console.ReadLine();
    }
}








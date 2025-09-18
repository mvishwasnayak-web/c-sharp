using System;
using System.Transactions;
class program
{ 
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0, Temp = num;
        while (Temp > 0)
        {
            int digit = Temp % 10;
            sum += digit * digit * digit;
            Temp /= 10;
                }
        if (num == sum)
        {
            Console.WriteLine("AMSTROM");
        }
        else
        {
            Console.WriteLine("NOT AMSTROM");
        }



        }


        }
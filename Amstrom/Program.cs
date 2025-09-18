using System;
class Program
{
    static void Main()
        {
         int num, a, b, c, d;
         for(int i = 1; i <= 1000; i++) 
        {
            num = i;
            a = num % 10;
            b = (num / 10) % 10; 
            c = (num / 100) % 10;
            d = (num / 1000) % 10;
            if (a * a * a + b * b * b + c * c * c + d * d * d == num)
            {
                Console.WriteLine(num);
            }
        }
         Console.ReadLine();
    }
}





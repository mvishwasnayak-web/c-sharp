using System;
using System.Drawing;
using ClassLibrary1;
namespace C
{
    class point
    {
        internal int x;
        internal int y;
        public void Test()
        {
            Console.WriteLine("Test () method in point class");
            Console.WriteLine("Created a new point object variable");

        }
    }
    class program : point
    {
        static void Main()
        {
            point p = new point();
            program p1 = new program();
            p1.Test();
            //p.Test();
        }
    }
    namespace N
    {
        class sample
        {
            public void Display()
            {
                C.point p = new C.point();

            }
        }

    }
} 


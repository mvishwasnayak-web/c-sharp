using System;
class shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("Erasing the shape");
    }
}
class circle : shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing the shape");
    }
}
class triangle : shape
{
     public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing the shape");
    }
}
class program
{
    static void Main()
    {
        shape[] shape = (new circle(), new triangle());
        foreach (shape s in shapes)
        {
            s.Draw();
            s.Erase();
            Console.WriteLine();
        }
        
    }
    
}
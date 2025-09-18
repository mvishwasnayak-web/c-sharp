using System;

interface IResizeWidth
{
    void ResizeWidth(double width);
}

interface IResizeHeight
{
    void ResizeHeight(double height);
}

class Rectangle : IResizeWidth, IResizeHeight
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(double width)
    {
        this.width = width;
        Console.WriteLine($"Width resized to: {this.width}");
    }

    public void ResizeHeight(double height)
    {
        this.height = height;
        Console.WriteLine($"Height resized to: {this.height}");
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle: Width = {width}, Height = {height}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10.0, 5.0);
        rect.Display();

        rect.ResizeWidth(20.0);
        rect.ResizeHeight(15.0);
        rect.Display();

        Console.ReadLine();
    }
}

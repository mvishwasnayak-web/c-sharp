using System;

public interface IVehicle
{
    void Start();
    void Stop();
}

public class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("The car is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("The car is stopping...");
    }
}

public class Truck : IVehicle
{
    public void Start()
    {
        Console.WriteLine("The truck is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("The truck is stopping...");
    }
}

public class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("The bike is starting...");
    }
    public void Stop()
    {
        Console.WriteLine("The bike is stopping...");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        IVehicle myCar = new Car();
        IVehicle myTruck = new Truck();
        IVehicle myBike = new Bike();

        Console.WriteLine("Demonstrating car:");
        myCar.Start();
        myCar.Stop();

        Console.WriteLine("\nDemonstrating truck:");
        myTruck.Start();
        myTruck.Stop();

        Console.WriteLine("\nDemonstrating bike:");
        myBike.Start();
        myBike.Stop();
    }
}

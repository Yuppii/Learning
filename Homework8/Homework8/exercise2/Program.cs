public abstract class Transport
{
    public abstract Engine Engine { get; set; }

    public abstract void Move();
}

public class Engine
{
    public void Turn()
    {
        Console.Write("Двигатель включен.");
    }
}

public class Car : Transport
{
    public override Engine Engine { get; set; }

    public Car() 
    { 
        Engine = new Engine();
    }

    public override void Move()
    {
        Engine.Turn();
        Console.WriteLine("Машина тронулась.");
    }
}

public class Plane : Transport
{
    public override Engine Engine { get; set; }

    public Plane()
    {
        Engine = new Engine();
    }

    public override void Move()
    {
        Engine.Turn();
        Console.WriteLine("Самолет взлетел.");
    }
}

internal class Program
{
    private static void Main()
    {
        Car car = new Car();

        car.Move();

        Plane plane = new Plane();

        plane.Move();
    }
}
using System;
using System.Drawing;

interface IMovable
{
    void Move(int x, int y);
}

class Vehicle : IMovable
{
    public Point Position { get; set; }

    public void Move(int x, int y)
    {
        Position = new Point(x, y);
    }
}

class Car : Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Двигун запущено");
    }

    public void StopEngine()
    {
        Console.WriteLine("Двигун зупинено");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();

        Console.WriteLine("Початкова позиція автомобіля:");
        Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

        myCar.Move(10, 20);
        Console.WriteLine("Автомобіль переміщено на нову позицію:");
        Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

        myCar.StartEngine();
        myCar.Move(15, 25);
        Console.WriteLine("Автомобіль переміщено на іншу позицію після запуску двигуна:");
        Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

        myCar.StopEngine();
        Console.ReadLine();
    }
}

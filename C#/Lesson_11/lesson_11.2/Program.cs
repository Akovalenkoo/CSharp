using System;

class Transport
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Transport(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Транспорт: {Name}, Максимальна швидкість: {MaxSpeed} км/год");
    }
}

class Car : Transport
{
    public int NumberOfDoors { get; set; }

    public Car(string name, int maxSpeed, int numberOfDoors) : base(name, maxSpeed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Кількість дверей: {NumberOfDoors}");
    }
}

class Bicycle : Transport
{
    public string BicycleType { get; set; }

    public Bicycle(string name, int maxSpeed, string bicycleType) : base(name, maxSpeed)
    {
        BicycleType = bicycleType;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип велосипеда: {BicycleType}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Моя машина", 200, 4);
        Bicycle myBicycle = new Bicycle("Мій велосипед", 30, "Шосе");

        Console.WriteLine("Інформація про автомобіль:");
        myCar.DisplayInfo();

        Console.WriteLine("\nІнформація про велосипед:");
        myBicycle.DisplayInfo();

        Console.ReadKey();
    }
}


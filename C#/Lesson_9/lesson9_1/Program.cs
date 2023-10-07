using System;

public class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину сторони 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle myRectangle = new Rectangle(side1, side2);
        Console.WriteLine($"Площа прямокутника: {myRectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {myRectangle.Perimeter}");
        Console.ReadKey();

    }
}

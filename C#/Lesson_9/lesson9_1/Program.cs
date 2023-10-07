using System;

public class Rectangle
{
    // Поля, які описують довжини сторін
    private double side1;
    private double side2;

    // Конструктор класу
    public Rectangle(double side1, double side2)
    {
        // Ініціалізація полів значеннями аргументів конструктора
        this.side1 = side1;
        this.side2 = side2;
    }

    // Метод для обчислення площі прямокутника
    public double AreaCalculator()
    {
        return side1 * side2;
    }

    // Метод для обчислення периметру прямокутника
    public double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }

    // Властивість для отримання площі прямокутника
    public double Area
    {
        get { return AreaCalculator(); }
    }

    // Властивість для отримання периметру прямокутника
    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }
}

class Program
{
    static void Main()
    {
        // Введення довжин сторін від користувача
        Console.Write("Введіть довжину сторони 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Створення об'єкта класу Rectangle за допомогою конструктора
        Rectangle myRectangle = new Rectangle(side1, side2);

        // Виведення результатів обчислень
        Console.WriteLine($"Площа прямокутника: {myRectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {myRectangle.Perimeter}");
        Console.ReadKey();
    }
}

using System;

class Фігура
{
    public int X { get; set; }
    public int Y { get; set; }

    public Фігура(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Коло : Фігура
{
    public int Радіус { get; set; }

    public Коло(int x, int y, int радіус) : base(x, y)
    {
        Радіус = радіус;
    }
}

class Прямокутник : Фігура
{
    public int Ширина { get; set; }
    public int Висота { get; set; }
    public Прямокутник(int x, int y, int ширина, int висота) : base(x, y)
    {
        Ширина = ширина;
        Висота = висота;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть координату X для кола:");
        int xКоло = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть координату Y для кола:");
        int yКоло = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть радіус для кола:");
        int радіусКоло = int.Parse(Console.ReadLine());

        Коло коло = new Коло(xКоло, yКоло, радіусКоло);

        Console.WriteLine("Введіть координату X для прямокутника:");
        int xПрямокутник = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть координату Y для прямокутника:");
        int yПрямокутник = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть ширину для прямокутника:");
        int ширинаПрямокутник = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть висоту для прямокутника:");
        int висотаПрямокутник = int.Parse(Console.ReadLine());

        Прямокутник прямокутник = new Прямокутник(xПрямокутник, yПрямокутник, ширинаПрямокутник, висотаПрямокутник);

        Console.WriteLine("Інформація про Коло:");
        Console.WriteLine($"Координати: ({коло.X}, {коло.Y})");
        Console.WriteLine($"Радіус: {коло.Радіус}");
        Console.WriteLine();

        Console.WriteLine("Інформація про Прямокутник:");
        Console.WriteLine($"Координати: ({прямокутник.X}, {прямокутник.Y})");
        Console.WriteLine($"Ширина: {прямокутник.Ширина}, Висота: {прямокутник.Висота}");

        Console.ReadLine();
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number == number2)
        {
            Console.WriteLine($"{number} = {number2}");
        }
        else if (number > number2)
        {
            Console.WriteLine($"{number} > {number2}");
        }
        else
        {
            Console.WriteLine($"{number} < {number2}");
        }
        Console.ReadKey();
    }
}

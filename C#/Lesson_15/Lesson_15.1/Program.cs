using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1) Фільтрація
        List<int> numbers = new List<int> { 2, 5, 8, 12, 15, 18, 22 };
        var filteredNumbers = numbers.Where(n => n > 10);
        Console.WriteLine("Фільтрація:");
        Console.WriteLine(string.Join(", ", filteredNumbers));

        // 2) Сортування
        List<string> fruits = new List<string> { "Яблуко", "Апельсин", "Банан", "Ківі" };
        var sortedFruits = fruits.OrderBy(fruit => fruit);
        Console.WriteLine("\nСортування:");
        Console.WriteLine(string.Join(", ", sortedFruits));

        // 3) Видалення дублікатів
        List<string> strings = new List<string> { "А", "Б", "В", "А", "Г", "В" };
        var uniqueStrings = strings.Distinct();
        Console.WriteLine("\nВидалення дублікатів:");
        Console.WriteLine(string.Join(", ", uniqueStrings));

        // 4) Підрахунок
        List<int> grades = new List<int> { 85, 92, 78, 95, 88, 90 };
        int studentsAbove90 = grades.Count(grade => grade > 90);
        Console.WriteLine("\nПідрахунок студентів з оцінками більше 90 балів:");
        Console.WriteLine(studentsAbove90);

        // 5) Фільтрація та сортування
        List<Product> products = new List<Product>
        {
            new Product { Name = "Продукт 1", Price = 45 },
            new Product { Name = "Продукт 2", Price = 30 },
            new Product { Name = "Продукт 3", Price = 60 },
            new Product { Name = "Продукт 4", Price = 20 },
        };
        var cheapProducts = products.Where(product => product.Price < 50).OrderBy(product => product.Price);
        Console.WriteLine("\nФільтрація та сортування товарів за ціною:");
        foreach (var product in cheapProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price} грн");
        }

        // 6) Пошук максимального за індексом
        List<int> integers = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
        int maxByIndex = integers.Select((value, index) => new { Value = value, Index = index }).Max(item => item.Value);
        Console.WriteLine("\nПошук максимального числа за індексом:");
        Console.WriteLine($"Максимальне число: {maxByIndex}");
        Console.ReadLine();
    } 
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}


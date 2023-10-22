using System;
using System.Collections.Generic;

class Order
{
    public int OrderNumber { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<Order> orderQueue = new Queue<Order>();
        int processedOrders = 0;
        double totalProcessedAmount = 0;

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Додати замовлення");
            Console.WriteLine("2. Обробити чергу замовлень");
            Console.WriteLine("3. Вийти");
            Console.ReadLine();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Номер замовлення: ");
                    int orderNumber = int.Parse(Console.ReadLine());

                    Console.Write("Ім'я клієнта: ");
                    string customerName = Console.ReadLine();

                    Console.Write("Загальна сума замовлення: ");
                    double totalAmount = double.Parse(Console.ReadLine());

                    Order newOrder = new Order
                    {
                        OrderNumber = orderNumber,
                        CustomerName = customerName,
                        TotalAmount = totalAmount
                    };

                    orderQueue.Enqueue(newOrder);
                    Console.WriteLine("Замовлення додано до черги.");
                    break;

                case 2:
                    if (orderQueue.Count > 0)
                    {
                        Order nextOrder = orderQueue.Dequeue();
                        Console.WriteLine("Обробка замовлення:");
                        Console.WriteLine($"Номер замовлення: {nextOrder.OrderNumber}");
                        Console.WriteLine($"Ім'я клієнта: {nextOrder.CustomerName}");
                        Console.WriteLine($"Загальна сума замовлення: {nextOrder.TotalAmount:C}");

                        processedOrders++;
                        totalProcessedAmount += nextOrder.TotalAmount;

                        Console.WriteLine("Замовлення оброблено та видалено з черги.");
                    }
                    else
                    {
                        Console.WriteLine("Черга замовлень пуста.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Програма завершила роботу.");
                    Console.WriteLine($"Загальна кількість оброблених замовлень: {processedOrders}");
                    Console.WriteLine($"Загальна сума оброблених замовлень: {totalProcessedAmount:C}");
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
}


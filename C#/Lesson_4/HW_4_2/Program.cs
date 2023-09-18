//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int secretNumber = random.Next(1, 147); // Генеруємо випадкове число від 1 до 146
//        int attempts = 0;
//        int guess;

//        Console.WriteLine("Вгадайте число від 1 до 146");

//        do
//        {
//            Console.Write("Вгадайте число: ");
//            guess = int.Parse(Console.ReadLine());
//            attempts++;

//            string hint = guess < secretNumber
//            Console.Write ? "вище" : guess > secretNumber ? "нижчий" : "правильно";Line(hint);
//        } while (guess != secretNumber);

//        Console.WriteLine($"Вітаю! Ви вгадали число {secretNumber} з {attempts} спроб.");
//        Console.ReadKey();
//    }
//}

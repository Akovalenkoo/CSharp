//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введіть число від 1 до 100: ");
//        if (int.TryParse(Console.ReadLine(), out int number))
//        {
//            if (number >= 1 && number <= 100)
//            {
//                if (number % 15 == 0)
//                {
//                    Console.WriteLine("FizzBuzz");
//                }
//                else if (number % 3 == 0)
//                {
//                    Console.WriteLine("Fizz");
//                }
//                else if (number % 5 == 0)
//                {
//                    Console.WriteLine("Buzz");
//                }
//                else
//                {
//                    Console.WriteLine($"{number} Число не кратне 3, 5, 15");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Число повинно бути від 1 до 100");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некоректне введення. Будь ласка, введіть число від 1 до 100.");
//        }

//        Console.ReadKey();
//    }
//}




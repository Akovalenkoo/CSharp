//using System;

//class Program
//{
//    static bool IsPrime(int number)
//    {
//        if (number <= 1)
//        {
//            return false; 
//        }

//        for (int i = 2; i * i <= number; i++)
//        {
//            if (number % i == 0)
//            {
//                return false; 
//            }
//        }

//        return true; 
//    }

//    static void Main()
//    {
//        Random random = new Random();
//        int genNum = random.Next(2, 1000);

//        if (IsPrime(genNum))
//        {
//            Console.WriteLine($"{genNum} is prime.");
//        }
//        else
//        {
//            Console.WriteLine($"{genNum} is not prime.");
//        }
//        Console.ReadKey();
//    }
//}


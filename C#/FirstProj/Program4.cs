//namespace HelloWorld
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть номер місяця");
//            byte Month = byte.Parse(Console.ReadLine());

//            switch (Month)
//            {
//                case 1:
//                    Console.WriteLine("січень");
//                    Console.ReadKey();
//                    break;
//                case 2:
//                    Console.WriteLine("лютий");
//                    Console.ReadKey();
//                    break;
//                case 3:
//                    Console.WriteLine("березень");
//                    Console.ReadKey();
//                    break;
//                case 4:
//                    Console.WriteLine("квітень");
//                    Console.ReadKey();
//                    break;
//                case 5:
//                    Console.WriteLine("травень");
//                    Console.ReadKey();
//                    break;
//                case 6:
//                    Console.WriteLine("червень");
//                    Console.ReadKey();
//                    break;
//                case 7:
//                    Console.WriteLine("липень");
//                    Console.ReadKey();
//                    break;
//                case 8:
//                    Console.WriteLine("серпень");
//                    Console.ReadKey();
//                    break;
//                case 9:
//                    Console.WriteLine("вересень");
//                    Console.ReadKey();
//                    break;
//                case 10:
//                    Console.WriteLine("жовтень");
//                    Console.ReadKey();
//                    break;
//                case 11:
//                    Console.WriteLine("листопад");
//                    Console.ReadKey();
//                    break;
//                case 12:
//                    Console.WriteLine("грудень");
//                    Console.ReadKey();
//                    break;
//                default:
//                    Console.WriteLine("нема такого місяця");
//                    Console.ReadKey();
//                    break;

//            }

//        }
//    }
//}

//АБО

using System;

class Program
{
    static void Main()
    {
        string input;
        int month;

        do
        {
            Console.Write("Введіть номер місяця (1-12): ");
            input = Console.ReadLine();

            if (int.TryParse(input, out month))
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("Січень");
                        break;
                    case 2:
                        Console.WriteLine("Лютий");
                        break;
                    case 3:
                        Console.WriteLine("Березень");
                        break;
                    case 4:
                        Console.WriteLine("Квітень");
                        break;
                    case 5:
                        Console.WriteLine("Травень");
                        break;
                    case 6:
                        Console.WriteLine("Червень");
                        break;
                    case 7:
                        Console.WriteLine("Липень");
                        break;
                    case 8:
                        Console.WriteLine("Серпень");
                        break;
                    case 9:
                        Console.WriteLine("Вересень");
                        break;
                    case 10:
                        Console.WriteLine("Жовтень");
                        break;
                    case 11:
                        Console.WriteLine("Листопад");
                        break;
                    case 12:
                        Console.WriteLine("Грудень");
                        break;
                    default:
                        Console.WriteLine("Немає такого місяця на цій планеті");
                        break;
                }
 
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Введіть число від 1 до 12.");
            }

            Console.Write("Бажаєте ввести ще один місяць? (Так/Ні): ");
            input = Console.ReadLine();
        } while (input.ToLower() == "так");
    }
}

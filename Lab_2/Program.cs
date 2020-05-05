using System;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bus Num: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            SwichBus(Num);

        }
        private static void SwichBus(int BusNum)
        {
            int min = 0 , max = 9;

            if (BusNum < max && BusNum > min)
            {
                switch (BusNum)
                {
                    case 1:
                        Console.WriteLine("Lviv - Kiev");
                        break;
                    case 2:
                        Console.WriteLine("Lviv - Striy");
                        break;
                    case 3:
                        Console.WriteLine("Striy - Kiev");
                        break;
                    case 4:
                        Console.WriteLine("Striy - Kiev");
                        break;
                    case 5:
                        Console.WriteLine("Striy - Kiev");
                        break;
                    case 6:
                        Console.WriteLine("Striy - Kiev");
                        break;
                    case 7:
                        Console.WriteLine("Striy - Kiev");
                        break;
                    case 8:
                        Console.WriteLine("Striy - Kiev");
                        break;
                    case 9:
                        Console.WriteLine("Striy - Kiev");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Wrong Bus Name");
            }
        }
    }
}

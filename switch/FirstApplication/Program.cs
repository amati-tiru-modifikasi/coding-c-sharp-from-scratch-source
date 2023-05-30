using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 10;

            switch (month)
            {
                case 1:
                    Console.WriteLine("First month");
                    break;
                case 2:
                    Console.WriteLine("Second month");
                    break;
                case 3:
                    Console.WriteLine("Third month");
                    break;
                case 4:
                    Console.WriteLine("Fourth month");
                    break;
                case 5:
                    Console.WriteLine("Fifth month");
                    break;
                default:
                    Console.WriteLine("The default value");
                    break;
            }
        }
    }
}
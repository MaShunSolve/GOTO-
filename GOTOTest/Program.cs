using System;
using System.Diagnostics;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i > 9)
                {
                    goto BiggerThanNine;
                }
                Console.WriteLine(i);
            }
        BiggerThanNine:
            Console.WriteLine("大於9");
            Console.WriteLine("test123");
        }
    }
}
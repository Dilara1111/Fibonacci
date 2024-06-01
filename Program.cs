using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            int num1 = int.Parse(Console.ReadLine());
            int a1 = 0;
            int a2 = 1;
            for (int i = 0; i < num1; i++)
            {
                a1 = a1 + a2;
                a2 = a1 - a2;
                Console.WriteLine(a2);
            }
        }
    }
}

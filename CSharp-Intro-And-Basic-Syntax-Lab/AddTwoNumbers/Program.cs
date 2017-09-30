using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int total = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, total);
        }
    }
}

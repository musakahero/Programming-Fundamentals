using System;


namespace CSharp_Intro_and_Basic_Syntax_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num0:D4} {num1:D4} {num2:D4} {num3:D4}");
        }
    }
}

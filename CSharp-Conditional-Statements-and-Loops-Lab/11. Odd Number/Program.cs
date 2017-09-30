using System;


namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumber = int.Parse(Console.ReadLine());

            while (oddNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                oddNumber = int.Parse(Console.ReadLine());
            }

            if (oddNumber < 0)
            {
                oddNumber = oddNumber * -1;
                Console.WriteLine($"The number is: {oddNumber}");
            }
            else
            {
                Console.WriteLine($"The number is: {oddNumber}");
            }
        }
    }
}

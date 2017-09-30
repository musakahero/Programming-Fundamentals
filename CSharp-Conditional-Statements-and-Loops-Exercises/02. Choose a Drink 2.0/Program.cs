using System;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch (profession)
            {
                case "Athlete":
                    //Console.WriteLine("Water");
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    //Console.WriteLine("Coffee");
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    //Console.WriteLine("Beer");
                    price = 1.70;
                    break;
                default:
                    //Console.WriteLine("Tea");
                    price = 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {quantity * price:F2}.");
        }
    }
}

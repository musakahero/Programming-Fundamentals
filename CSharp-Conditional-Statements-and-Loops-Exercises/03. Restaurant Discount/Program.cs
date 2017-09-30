using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double priceOfHall = 0;
            string typeOFHall = "";
            double packagePrice = 0.0;
            double discount = 0.0;

            if (countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (countOfPeople <= 50)
                {
                    priceOfHall = 2500;
                    typeOFHall = "Small Hall";

                }
                else if (countOfPeople > 50 && countOfPeople <= 100)
                {
                    priceOfHall = 5000;
                    typeOFHall = "Terrace";
                }
                else if (countOfPeople > 100 && countOfPeople <= 120)
                {
                    priceOfHall = 7500;
                    typeOFHall = "Great Hall";
                }

                switch (package)
                {
                    case "Normal":
                        packagePrice = 500;
                        discount = 0.05;
                        break;

                    case "Gold":
                        packagePrice = 750;
                        discount = 0.1;
                        break;

                    case "Platinum":
                        packagePrice = 1000;
                        discount = 0.15;
                        break;
                }

                double priceWithoutDiscount = packagePrice + priceOfHall;
                double total = priceWithoutDiscount - (priceWithoutDiscount * discount);

                Console.WriteLine($"We can offer you the {typeOFHall}");
                Console.WriteLine($"The price per person is {total / countOfPeople:F2}$");

            }
        }
    }
}

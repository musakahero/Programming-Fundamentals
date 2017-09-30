using System;


namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studio = 0.0;
            double doubleRoom = 0.0;
            double suite = 0.0;

            if (nightsCount >= 0 || nightsCount >= 200)
            {
                switch (month)
                {
                    case "May":
                    case "October":
                        studio = 50;
                        doubleRoom = 65;
                        suite = 75;
                        if (nightsCount > 7)
                        {
                            studio = 50 - (50 * 0.05);
                        }
                        break;

                    case "June":
                    case "September":
                        studio = 60;
                        doubleRoom = 72;
                        suite = 82;
                        if (nightsCount > 14)
                        {
                            doubleRoom = 72 - (72 * 0.01);
                        }
                        break;

                    case "July":
                    case "August":
                    case "December":
                        studio = 68;
                        doubleRoom = 77;
                        suite = 89;
                        if (nightsCount > 14)
                        {
                            suite = 89 - (89 * 0.15);
                        }
                        break;
                }

                double studioTotal = studio * nightsCount;
                double doubleTotal = doubleRoom * nightsCount;
                double suiteTotal = suite * nightsCount;

                if ((month == "September" || month == "October") && nightsCount > 7)
                {
                    studioTotal -= studio;
                }

                Console.WriteLine($"Studio: {studioTotal:F2} lv.");
                Console.WriteLine($"Double: {doubleTotal:F2} lv.");
                Console.WriteLine($"Suite: {suiteTotal:F2} lv.");
            }
        }
    }
}

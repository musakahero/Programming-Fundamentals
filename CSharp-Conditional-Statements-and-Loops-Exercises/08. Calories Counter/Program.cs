using System;


namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

          
                switch (ingredient)
                {
                    case "cheese":
                        total = total + 500;
                        break;

                    case "tomato sauce":
                        total = total + 150;
                        break;

                    case "salami":
                        total = total + 600;
                        break;
                    case "pepper":
                        total = total + 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {total}");
        }
    }
}

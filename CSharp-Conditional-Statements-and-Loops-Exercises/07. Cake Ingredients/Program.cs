using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = 0;
           
            for (int i = 0; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    numberOfIngredients++;
                }
            }
        }
    }
}

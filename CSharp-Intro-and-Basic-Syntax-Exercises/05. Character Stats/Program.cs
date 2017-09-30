using System;


namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var maxHealthLeft = maxHealth - currentHealth;

            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            var maxEnergyLeft = maxEnergy - currentEnergy;

            Console.WriteLine("Name: {0}", name);
            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth)); ;
            Console.Write(new string('.', maxHealthLeft));
            Console.WriteLine('|');

            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maxEnergyLeft));
            Console.WriteLine('|');
        }
    }
}

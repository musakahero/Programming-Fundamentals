using System;


namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    var input = int.Parse(Console.ReadLine());
                    numbers++;
                }
            }

            catch (Exception)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}

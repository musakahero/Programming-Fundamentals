using System;


namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());

            int theNumber1 = 0;
            int theNumber2 = 0;
            int theNumberTotal = 0;
            int j = num1;
            int k = num1;
            int counter0 = 0;
           

            while (num1 <= num2)
            {



                while (j <= num2)
                {
                    

                    if (num1 + j == magical)
                    {
                        theNumber1 = num1;
                        theNumber2 = j;
                        theNumberTotal = num1 + j;
                    }

                    j++;
                    counter0++;
                }

                num1++;
                
                j = k;

            }
            if (theNumberTotal == 0)
            {
                Console.WriteLine($"{counter0} combinations - neither equals {magical}");
            }
            else
            {
                Console.WriteLine($"Number found! {theNumber1} + {theNumber2} = {theNumberTotal}");
            }
        }
    }
}

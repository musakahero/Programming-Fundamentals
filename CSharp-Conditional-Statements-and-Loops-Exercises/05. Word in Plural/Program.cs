using System;


namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                int lastLocation = noun.LastIndexOf("y");
                noun.Remove(lastLocation);
                noun = noun.Substring(0, lastLocation);
                Console.Write(noun);
                Console.WriteLine("ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") ||
                     noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.Write(noun);
                Console.WriteLine("es");
            }
            else
            {
                Console.Write(noun);
                Console.WriteLine("s");
            }
        }
    }
}

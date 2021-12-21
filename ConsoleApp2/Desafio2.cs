using System;

namespace ConsoleApp2
{
    internal class Desafio2
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if (v.Length <= 5) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");
        }
    }
}

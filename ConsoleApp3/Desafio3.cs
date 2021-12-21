using System;

namespace ConsoleApp3
{
    internal class Desafio3
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            int x = a + b;

            Console.WriteLine("X = {0}", x);
        }
    }
}

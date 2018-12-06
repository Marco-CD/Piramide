using System;

namespace Piramite
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribir una pirámide con *");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

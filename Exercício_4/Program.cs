using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 4");
            Console.WriteLine();
            Console.WriteLine("Tabuada do 1 Ao 10");

            for (var e = 0; e <=10; e++)
            {
                for (var d = 0; d <=10; d++)
                {
                    Console.WriteLine( + e +" x "+ d +" = "+e * d);
                }
                Console.WriteLine();
            }
        }
    }
}

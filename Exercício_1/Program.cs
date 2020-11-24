using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exerecício 1");
            Console.WriteLine("---------------------");

            Console.WriteLine("Digite o ano atual");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano em que nasceu");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual-anoNascimento;

            Console.WriteLine("Você tem "+idade);
            if (idade>16)
            {
                Console.WriteLine("Você já pode votar");
            }
            else
            {
               Console.WriteLine("Você ainda não pode votar");
            }
            
        }
    }
}

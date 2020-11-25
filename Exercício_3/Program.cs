using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("DIgite a quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("DIgite o perço");
            float preco = float.Parse(Console.ReadLine());

            float resultado = TotalAPagar;

            float TotalAPagar(int quantidade , float preco)
            {
                float total = quantidade * preco;
                float desconto;
                if(quantidade <=5){
                    desconto = 0.02f;
                }else if(quantidade <=10){
                    desconto = 0.03f;
                }else{
                    desconto = 0.05f;
                }
                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - valorDoDesconto;

                return totalComDesconto;
            }

        }
    }
}

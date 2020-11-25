using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço");
            float preco = float.Parse(Console.ReadLine());

            //chama o return pelo nome do método(TotalAPagar)
            //para exibir seu resultado
            TotalAPagar(quantidade , preco);

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
                    Console.WriteLine($"O valor total da compra é de R${total}");
                    Console.WriteLine($"Voce terá um desconto de R${valorDoDesconto}");
                    Console.WriteLine($"Sua compra deu R$ {totalComDesconto}");

                return totalComDesconto;
            }

        }
    }
}

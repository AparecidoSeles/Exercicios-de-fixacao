using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2");
            Console.WriteLine("---------------------");
            Console.WriteLine("A - Álcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Quantidade a quantidade de combustível");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());

            float percDesconto , desconto, valorTotal;
            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;

            switch (combustivel.ToLower())
            {
                case "a":
                if(quantidadeCombustivel>20){
                    percDesconto = 0.05f;
                }else{
                    percDesconto = 0.03f;
                }
                    valorTotal = (quantidadeCombustivel * precoAlcool);
                    desconto = (quantidadeCombustivel * precoAlcool) * percDesconto;
                    Console.WriteLine($"Seu desconto foi de R${desconto}");
                    Console.WriteLine($"Valor a ser pago{valorTotal-desconto}");
                    break;

                case "g":
                    if(quantidadeCombustivel>20){
                        percDesconto = 0.06f;
                    }else{
                        percDesconto = 0.04f;
                    }
                        valorTotal = (quantidadeCombustivel * precoGasolina);
                    desconto = (quantidadeCombustivel * precoGasolina) * percDesconto;
                    Console.WriteLine($"Seu desconto foi de R${desconto}");
                    Console.WriteLine($"Valor a ser pago{valorTotal-desconto}");
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            

        }
    }
}

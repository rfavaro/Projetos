using System;

namespace ValorLiquido.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do Produto: ");
            var nome_produto = Console.ReadLine();
            Console.WriteLine("Valor Unitário: ");
            var valor_unitario = Console.ReadLine();
            Console.WriteLine("Desconto Percentual: ");
            var desconto = Console.ReadLine();

            double desconto_liquido = double.Parse(valor_unitario) * (double.Parse(desconto)/100);

            Console.WriteLine($"Produto {nome_produto} Valor Unitario {valor_unitario} Desconto Percentual {desconto} Desconto Liquido {desconto_liquido}");
        }
    }
}

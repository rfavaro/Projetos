using System;

namespace ParOuImpar.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            var numero = Console.ReadLine();

            int resto = int.Parse(numero) % 2;

            string ImparPar = "";
            if (resto > 0) 
                ImparPar = "Impar";
            else 
                ImparPar = "Par";

            Console.WriteLine($"O numero {numero} é {ImparPar}");
        }
    }
}

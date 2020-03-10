using System;

namespace ExercicioTabuada.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor digite um número para calcular a tabuada:");
            var numeroReadLine = Console.ReadLine();

            if (int.TryParse(numeroReadLine, out var numero)) 
            {
             for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} X {i} = {numero * i}");        
                }            
            }
            else
                Console.WriteLine("Digite um valor válido");

        }
    }
}

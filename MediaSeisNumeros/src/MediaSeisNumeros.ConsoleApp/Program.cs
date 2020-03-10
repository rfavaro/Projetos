using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaSeisNumeros.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNumeros = new List<int>();
            for (int i = 0; i < 6; i++)
            {
               var numeroRequisitado = i + 1;     
               Console.WriteLine($"{numeroRequisitado} - Digite o número:");
               var numero = Console.ReadLine();
               int.TryParse(numero, out var numeroint);

               listaNumeros.Add(numeroint);  
            }

            //var media = listaNumeros.Sum() / float.Parse(listaNumeros.Count().ToString());    
            var media = listaNumeros.Average();        

           Console.WriteLine($"A média dos números é igual a {Math.Round(media, 2)}");

        }
    }
}

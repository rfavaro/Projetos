using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaSeisNumeros.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNumeros = new List<double>();
            for (int i = 0; i < 4; i++)
            {
               var numeroRequisitado = i + 1;     
               Console.WriteLine($"Digite a nota do Bimestre {numeroRequisitado}:");
               var numero = Console.ReadLine();
               double.TryParse(numero, out var numerodouble);

               listaNumeros.Add(numerodouble);  
            }
            
            var media = listaNumeros.Average();        

            string aprovadoReprovado = "";
            if (media > 5) 
                aprovadoReprovado = "Aprovado";
            else 
                aprovadoReprovado = "Repovado";

           Console.WriteLine($"O Aluno foi {aprovadoReprovado} com a média: {Math.Round(media, 2)}");

        }
    }
}

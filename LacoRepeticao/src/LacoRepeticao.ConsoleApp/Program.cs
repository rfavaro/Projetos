using System;
using System.Collections.Generic;

namespace LacoRepeticao.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>(){1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine($"Laco for {lista[i]}");
            
            var countWhile = 0;    
            while (countWhile < lista.Count)
            {
                Console.WriteLine($"Laco While {lista[countWhile]}");
                countWhile++;
            }

            foreach (var item in lista)
            {
                Console.WriteLine($"Laco ForEach: {item}");
            }
        }
    }
}

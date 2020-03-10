using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Colecoes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var arraylist = new ArrayList{1, 2,3, "Quatro", 5, 5.5F, DateTime.Now };

           foreach (var item in arraylist)
           {
               Console.WriteLine(item);
           }

           var list = new List<int> {1, 2, 3, 4, 5, 6, 7};

           foreach (var item in list)
           {
               Console.WriteLine(item);
           }

           var listFilterLinq = from item in list where item > 3 && item < 7 orderby item descending select item;

           foreach (var item in listFilterLinq)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine("------------------------------------------");

           var listFilterLambda = list.Where(l => l > 3 && l < 7).OrderByDescending(l => l);

           foreach (var item in listFilterLambda)
           {
               Console.WriteLine(item);
           }

            Console.WriteLine("------------------------------------------");

            var pessoas = new List<Pessoa> 
            {
                new Pessoa(1, "Rodrigo", "123456"),
                new Pessoa(2, "Jose", "12345688"),
                new Pessoa(3, "Maria", "12345699")
            };

            var pessoasFiltradas = pessoas.Where(p => p.Cpf == "123456");

            foreach (var pessoa in pessoasFiltradas)
            {
                Console.WriteLine($"{pessoa.id}, {pessoa.Nome}, {pessoa.Cpf}");
            } 

            Console.WriteLine("------------------------------------------");

            var dictionaryProduct = new Dictionary<int, string>();
            dictionaryProduct.Add(1, "Abacaxi");
            dictionaryProduct.Add(2, "Abacate");
            dictionaryProduct.Add(3,"Maca");
            dictionaryProduct.Add(4,"Pera");
            dictionaryProduct.Add(5,"Banana");

            foreach (var item in dictionaryProduct)
            {
                Console.WriteLine($"Produto {item.Key}-{item.Value}");                
            }

            Console.WriteLine("------------------------------------------");

            var dictionaryProductFilter = dictionaryProduct.Where(d => d.Key >= 2 && d.Key <= 4);

            foreach (var item in dictionaryProductFilter)
            {
                Console.WriteLine($"Produto filtrado {item.Key}-{item.Value}");    
            }

            Console.WriteLine("------------------------------------------");

            var dictionaryPessoas = new Dictionary<int, Pessoa>();

            dictionaryPessoas.Add(1, new Pessoa(1, "Pessoa 1", "111111"));
            dictionaryPessoas.Add(2, new Pessoa(2, "Pessoa 2", "222222"));
            dictionaryPessoas.Add(3, new Pessoa(3, "Pessoa 3", "3333333"));
            dictionaryPessoas.Add(4, new Pessoa(4, "Pessoa 4", "4444444"));
            dictionaryPessoas.Add(5, new Pessoa(5, "Pessoa 5", "5555555"));

          foreach (var item in dictionaryPessoas)
          {
              Console.WriteLine($"Pessoa id: {item.Key} - Nome: {item.Value.Nome} - CPF: {item.Value.Cpf}");
          }

          Console.WriteLine("------------------------------------------");

          var dictionaryPessoasFilter = dictionaryPessoas.Where(d => d.Key > 3);

          foreach (var item in dictionaryPessoasFilter)
          {
             Console.WriteLine($"Pessoa id: {item.Key} - Nome: {item.Value.Nome} - CPF: {item.Value.Cpf}");
          }

        }

        public class Pessoa 
        {
            public Pessoa(int id, string nome, string cpf)
        {
            id = id;
            Nome = nome;
            Cpf = cpf;
        }
            public int id {get; set;}
            public string Nome {get; set;}
            public string Cpf {get; set;}
        }
    }
}

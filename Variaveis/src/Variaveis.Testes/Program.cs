using System;
using System.Collections.Generic;

namespace Variaveis.Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char caractere = 'S';
            float numerofloat = 1.25F;
            double numeroDouble = 1.55D;
            decimal numeroDecimal = 2.33333333M;
            string[] arrayTexto = new string[2];
            arrayTexto[0] = "Teste 1";
            arrayTexto[1] = "Teste 2";

            List<string> listatexto = new List<string>();
            listatexto.Add("Teste lista 1");
            listatexto.Add("Teste Lista 2");

            List<DateTime> listaDataHora = new List<DateTime>();
            listaDataHora.Add(DateTime.Now);
            listaDataHora.Add(DateTime.Now.AddHours(-1));

            const string constexto = "Teste constante";

            var formaPagamento = new FormaPagamento();
            formaPagamento.FormaPagamentoId = 1;
            formaPagamento.Descricao = "Dinheiro";

            object objeto = formaPagamento;
            dynamic dinamico = formaPagamento;

            Console.WriteLine(caractere);
            Console.WriteLine(numerofloat);
            Console.WriteLine(numeroDouble);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(arrayTexto[0]);
            Console.WriteLine(arrayTexto[1]);
            Console.WriteLine(listatexto[0]);
            Console.WriteLine(listatexto[1]);
            Console.WriteLine(listaDataHora[0]);
            Console.WriteLine(listaDataHora[1]);
            Console.WriteLine((int)FormaPagamentoEnum.Dinheiro);
            Console.WriteLine(constexto);
            Console.WriteLine(formaPagamento.Descricao);
        //    Console.WriteLine(((formaPagamento)objeto).Descricao);
            Console.WriteLine(dinamico.Descricao);
            Console.WriteLine($"{listatexto[0]} {listatexto[1]}");

            var inteiroemstring = "5";
            var somainteiro = int.Parse(inteiroemstring) + 5;
            Console.WriteLine(somainteiro);
            
        }

        public enum FormaPagamentoEnum {
            Dinheiro = 1, Cheque = 2, CartaoCredito = 3, CartaoDebito = 4
        }

        public class FormaPagamento {
            public int FormaPagamentoId { get; set; }
            public string Descricao { get; set; }

        }
    }
}

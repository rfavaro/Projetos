using System;

namespace Metodos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa("Rodrigo", new DateTime(1980, 06, 01)) ;
          
            var array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
         
            Console.WriteLine($"{pessoa.Nome} tem {CalcularIdade(pessoa.DataNascimento)} anos de idade");
            Console.WriteLine(ConcatenarArraySemParams(array));
            Console.WriteLine(ConcatenarArrayComParams(1,2,3,4,5,6));

            Console.WriteLine("===========================================================");
            Console.WriteLine(ValorDesconto("Anador", 10, 10));
            Console.WriteLine(ValorProdutoComDesconto("Viagra", 100, 10));
            Console.WriteLine(CalcularMedia("Rodrigo", 9.5, 8, 7, 6, 8));
            

        }

        private static string ValorDesconto(string produto, double valorUnitario, double percentual)
        {
            double valorDesc = valorUnitario * (percentual/100);

            return $"Produto: {produto} - Valor Unitário: R$ {valorUnitario} - Valor Desconto R$ {valorDesc}";
        }

        private static string ValorProdutoComDesconto(string produto, double valorUnitario, double percentual)
        {
            double valorComDesc = valorUnitario - (valorUnitario * (percentual/100));

            return $"Produto: {produto} - Valor Unitário: R$ {valorUnitario} - Valor com o Desconto de {percentual}% R$ {Math.Round(valorComDesc, 2)}";
        }

        private static string CalcularMedia(string nome, params double[] arrayNotas)
        {
            double soma = 0;
            for (int i = 0; i < arrayNotas.Length; i++) 
            {
                soma += arrayNotas[i];                
            }

            soma = soma/arrayNotas.Length;

            return $"O aluno {nome} tem a média: {soma}"; 
        }
        private static int CalcularIdade(DateTime dataNascimento) 
        {
            
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;

            if (dataAtual.DayOfYear < dataNascimento.DayOfYear) 
                idade--;

            return idade;
        }

        private static string ConcatenarArraySemParams(int[] arrayInt) 
        {
            return ConcatenarArray(arrayInt);
        }

        private static string ConcatenarArrayComParams(params int[] arrayInt) 
        {
            return ConcatenarArray(arrayInt);
        }

        private static string ConcatenarArray(int[] arrayInt)
        {
            var texto = "";
            for (int i = 0; i < arrayInt.Length; i++) 
            {
                texto += $"{arrayInt[i]}, ";
            }

            texto = texto.Substring(0, texto.Length-2);

            return texto;
        }

    }
}

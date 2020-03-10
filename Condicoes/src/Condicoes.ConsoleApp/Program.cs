using System;

namespace Condicoes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaAluno = 8;

            if (notaAluno < 7) 
                Console.WriteLine("O aluno foi reprovado");
            else if (notaAluno >= 7 && notaAluno < 9.5)
                Console.WriteLine("O aluno foi aprovado");
            else
                Console.WriteLine("O aluno foi aprovado com merito");

            
            var diaDaSemana = 3;

            switch(diaDaSemana) 
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terca");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia da semana inválido");
                    break;

            }

        }
    }
}

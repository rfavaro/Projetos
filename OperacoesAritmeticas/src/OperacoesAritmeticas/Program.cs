using System;

namespace OperacoesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somar
            var numero1 = 10;
            var numero2 = 5;
            var soma = numero1 + numero2;

            Console.WriteLine($"Numero 1: {numero1}");
            Console.WriteLine($"Numero 2: {numero2}");
            Console.WriteLine($"Soma: {soma}");    
            Console.WriteLine($"Somar metodo: {Somar(numero1, numero2)}");     
            Console.WriteLine("----------------------------------------");
            
            //Subtrair
            var subtracao = numero1 - numero2;
            Console.WriteLine($"Subtracao: {subtracao}");
            Console.WriteLine($"Subtracao Metodo: {Subtrair(numero1, numero2)}");
            Console.WriteLine("----------------------------------------");

            //Multiplicacao
            var multiplicacao = numero1 * numero2;
            Console.WriteLine($"Multiplicacao: {multiplicacao}");
            Console.WriteLine($"Multiplicacao Metodo: {Multiplicar(numero1, numero2)}");

            //Divisao
            var divisao = numero1 / numero2;
            Console.WriteLine($"Divisao: {divisao}");
            Console.WriteLine($"Divisao Metodo: {Dividir(numero1, numero2)}");
            Console.WriteLine("----------------------------------------");
            

            //Resto da divisao
            var restodivisao = numero1 % numero2;
            Console.WriteLine($"Resto de Divisao: {restodivisao}");
            Console.WriteLine($"Resto Divisao Metodo: {RestoDividir(3, 4)}");
            Console.WriteLine("----------------------------------------");
            
            //Incremento
            var numero3 = 3;
            var incremento = 0;
            incremento += numero3;
            incremento += numero1;
            Console.WriteLine($"Incremento: {incremento}");

            //Decremento;
            var decremento = 12;
            decremento -= numero3;
            Console.WriteLine($"Decremento: {decremento}");

            
            
        }

        private static int RestoDividir(int numero1, int numero2)
        {
            return numero1 % numero2;
        }
        private static decimal Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
        private static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        private static int Somar(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }

        private static int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        
    }
}

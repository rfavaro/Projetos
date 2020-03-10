using System;

namespace AreaTriangulo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do triângulo em cm: ");
            var base_triangulo = Console.ReadLine();
            Console.WriteLine("Digite a altura do triângulo em cm: ");
            var altura = Console.ReadLine();

            double area = (double.Parse(base_triangulo) * double.Parse(altura))/2;

            Console.WriteLine($"Area do triângulo: {area}");      



        }
    }
}

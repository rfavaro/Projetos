using System;
namespace Metodos.ConsoleApp
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public string Nome { get;  }
        public DateTime DataNascimento {get; }

    }
}
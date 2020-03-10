using System;

namespace Excecao.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMensagemTelaSucesso();
            ExibirMensagemTelaErro();
            ExibirItensArray();

            Console.WriteLine("Aqui é o fim da nossa app");
        }

        private static void ExibirMensagemTelaSucesso() 
        {
            try 
            {
                Console.WriteLine("Método \"ExibirMensagemTelaSucesso()\" está executando com sucesso!");

            }
            catch(Exception ex) 
            {
                  Console.WriteLine($"Método \"ExibirMensagemTelaSucesso()\" está executando com erro! {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Finally do método \"ExibirMensagemTelaSucesso()\"");
            }

        }

        private static void ExibirMensagemTelaErro()
        {
            try
            {
                Convert.ToInt32("erro");
                Console.WriteLine("Método \"ExibirMensagemTelaErro\" esta executando com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Método \"ExibirMensagemTelaErro\" esta com erro: {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Finally do método \"ExibirMensagemTelaErro()\"");
            }

        }

        private static void ExibirItensArray()
        {
            try
            {
                var Array = new string[5];
                Array[0] = "teste1";
                Array[1] = "teste2";
                Array[2] = "teste3";
                Array[3] = "teste4";
                Array[4] = "teste5";
         
                Convert.ToInt32("erro teste");
         
                Array[5] = "teste6";
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Erro IndexOutOfRangeException: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro Exception: {ex.Message}");
            }
        }

        private static void MetodoNivelUm() 
        {
            try
            {
                MetodoNivelDois();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro {ex.Message}");
            }
        }

        private static void MetodoNivelDois()
        {
            throw new Exception("Estou forçando uma exceção");
            
            try 
            {
                Convert.ToInt32("erro");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

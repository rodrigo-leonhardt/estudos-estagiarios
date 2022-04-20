using System;
using System.Linq;

namespace ef03
{
    public class Program
    {        

        static void Main(string[] args)
        {
            DeletarClientes();

            IncluirCliente(1, "Rodrigo");
            IncluirCliente(2, "Natália");
            IncluirCliente(3, "Yuri");            

            ListarClientes();
        }

        static void IncluirCliente(int codigo, string nome)
        {                        
            Console.WriteLine($"> Incluindo cliente {codigo} {nome}");

            //Início do trecho para alteração

            //Fim do trecho para alteração
        }

        static void ListarClientes()
        {   
            Console.WriteLine("> Listando clientes ordenados");

            //Início do trecho para alteração

            //Fim do trecho para alteração            
        }

        static void DeletarClientes()
        {            
            Console.WriteLine("> Deletando clientes");

            //Início do trecho para alteração

            //Fim do trecho para alteração
        }

    }
}
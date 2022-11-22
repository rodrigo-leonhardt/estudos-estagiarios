using System;
using System.Linq;
using ef03.Modelos;

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
            using var db = new ContextoExemplo();

            db.Clientes.Add(new Cliente { Codigo = codigo, Nome = nome });
            db.SaveChanges();
            //Fim do trecho para alteração
        }

        static void ListarClientes()
        {   
            Console.WriteLine("> Listando clientes ordenados");

            //Início do trecho para alteração
            using var db = new ContextoExemplo();
            var clientes = db.Clientes.OrderBy(x => x.Nome).ToList();

            foreach(var cliente in clientes)
                Console.WriteLine($"- {cliente.Codigo} {cliente.Nome}");

            //Fim do trecho para alteração            
        }

        static void DeletarClientes()
        {            
            Console.WriteLine("> Deletando clientes");

            //Início do trecho para alteração
            using var db = new ContextoExemplo();
            db.Clientes.RemoveRange(db.Clientes.ToArray());
            db.SaveChanges();
            //Fim do trecho para alteração
        }

    }
}
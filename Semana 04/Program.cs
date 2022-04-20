using System;

namespace ConceitosOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var novoCliente = new Cliente("João", "Mendez");

            novoCliente.Falar();
            novoCliente.Falar("Olá mundo");

            Console.WriteLine($"O nome completo do cliente é {novoCliente.NomeCompleto()}");
        }
    }    

}
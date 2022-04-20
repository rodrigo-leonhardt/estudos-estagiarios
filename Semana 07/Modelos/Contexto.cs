using Microsoft.EntityFrameworkCore;

namespace EF01.Modelos
{
    public class ContextoExemplo : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("exemplo");
        }

        //Início do trecho para alteração
        public ?? Clientes { get; set; }
        public ?? NotasFiscais { get; set; }
        //Fim do trecho para alteração

    }
}
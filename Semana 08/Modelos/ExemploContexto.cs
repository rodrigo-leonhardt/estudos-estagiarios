using System;
using Microsoft.EntityFrameworkCore;

namespace ef02.Modelos
{
    public class ExemploContexto : DbContext
    {
        public ExemploContexto(DbContextOptions<ExemploContexto> options) : base(options)
        {            
        }

        public static ExemploContexto NovaConexao()
        {
            var options = new DbContextOptionsBuilder<ExemploContexto>()
                .UseInMemoryDatabase("Exemplo")
                .Options;
            
            return new ExemploContexto(options);
        }

        public DbSet<Filosofo> Filosofos { get; set; } = null!;

    }

}
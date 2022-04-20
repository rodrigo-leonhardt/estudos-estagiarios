using System.ComponentModel.DataAnnotations;

namespace ef02.Modelos
{
    public class Filosofo
    {
        [Key]
        public int Codigo { get; set; }

        public string? Nome { get; set; }

        public string? Citacao { get; set; }

    }
}
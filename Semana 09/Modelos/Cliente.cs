using System;
using System.Collections.Generic;

namespace ef03.Modelos
{
    public partial class Cliente
    {
        public long Codigo { get; set; }
        public string Nome { get; set; } = null!;
    }
}

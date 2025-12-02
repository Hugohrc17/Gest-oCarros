using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCarros.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }

        public string? Nome { get; set; }

        public int MyProperty { get; set; }
    }
}
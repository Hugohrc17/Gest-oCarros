using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GestãoCarros.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
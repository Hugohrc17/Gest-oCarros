using System.ComponentModel.DataAnnotations;

namespace GestãoCarros.Models.Dtos
{
    public class UsuarioDto
    {
        public string? Nome { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
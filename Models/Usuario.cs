using System.ComponentModel.DataAnnotations;


namespace GestãoCarros.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Display(Name = "Digite seu Nome")]
        [MaxLength(150, ErrorMessage = "O nome não pode passar de 150 caracteres.")]
        public string? Nome { get; set; }

        [EmailAddress]
        [MaxLength(150)]
        [Display(Name = "Digite seu Email")]
        [Required(ErrorMessage = "O email é obrigatório.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [Display(Name = "Digite sua Senha")]
        public string? Senha { get; set; }

        public Venda? Vendas { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
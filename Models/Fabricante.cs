using System.ComponentModel.DataAnnotations;


namespace GestãoCarros.Models
{
    public class Fabricante
    {
        [Key]
        public Guid FabricanteId { get; set; }

        [Required(ErrorMessage = "O nome do fabricante é obrigatório.")]
        [Display(Name = "Nome do Fabricante")]
        [MaxLength(100, ErrorMessage = "O nome do fabricante não pode passar de 100 caracteres.")]
        public string? Nome { get; set; }

        [Required (ErrorMessage = "O país de origem é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O país de origem não pode passar de 50 caracteres.")]
        [Display(Name = "País de Origem")]
        public string? PaisOrigem { get; set; }

        [MaxLength(100)]
        [Display(Name = "Rua")]
        public string? Rua { get; set; }

        [MaxLength(50)]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [MaxLength(50)]
        [Display(Name = "Estado")]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [MaxLength(20)]
        [Display(Name = "Digite o CEP")]
        public string? CEP { get; set; }

        [Phone]
        [Display(Name = "Digite o Número")]
        public int Telefone { get; set; }

        [EmailAddress]
        [MaxLength(150)]
        [Display(Name = "Digite o Email")]
        public string? Email { get; set; }
        
        [Display(Name = "Ano de Fundação")]
        [Range(1900, 2025, ErrorMessage = "Ano inválido.")]
        public int AnoFundacao { get; set; }

        [Url]
        public string? Site { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
using System.ComponentModel.DataAnnotations;
using GestãoCarros.Models.Enums;


namespace GestãoCarros.Models
{
    public class Veiculo
    {
        [Key]
        public Guid VeiculoId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Modelo { get; set; }
        
        [Required]
        public int AnoFabricacao { get; set; }
        
        [Required]
        public decimal Preco { get; set; }

        [Required]
        public int FabricanteId { get; set; }
        
        public Fabricante? Fabricante { get; set; }

        [Required]
        public TipoVeiculo? Tipo { get; set; }

        [MaxLength(500)]
        public string? Descricao { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
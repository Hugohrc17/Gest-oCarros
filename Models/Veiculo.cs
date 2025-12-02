using System.ComponentModel.DataAnnotations;


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
        public int Preco { get; set; }

        [Required]
        public string? FabricanteId { get; set; }

        [Required]
        public string? Tipo { get; set; }

        [MaxLength(500)]
        public string? Descricao { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCarros.Models
{
    public class Fabricante
    {
        [Key]
        public Guid FabricanteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string? PaisOrigem { get; set; }

        public string? Rua { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        [Required]
        public string? CEP { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }
        
        [Required]
        public int AnoFundacao { get; set; }

        [Url]
        public string? Site { get; set; }
    }
}
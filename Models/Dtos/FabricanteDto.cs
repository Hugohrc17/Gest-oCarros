using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCarros.Models.Dtos
{
    public class FabricanteDto
    {
        public string? Nome { get; set; }

        public string? PaisOrigem { get; set; }

        public string? Rua { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? CEP { get; set; }

        public int Telefone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public int AnoFundacao { get; set; }
        
        [Url]
        public string? Site { get; set; }
    }
}
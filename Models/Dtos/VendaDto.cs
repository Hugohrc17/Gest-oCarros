using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCarros.Models.Dtos
{
    public class VendaDto
    {
        public Veiculo? Veiculo { get; set; }

        public Usuario? Usuario { get; set; }

        public decimal ValorVenda { get; set; }

        public string? ClienteNome { get; set; }

        public int ClienteCpf { get; set; }

        public DateTime DataVenda { get; set; } = DateTime.Now;
    }
}
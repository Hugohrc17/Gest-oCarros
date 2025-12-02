using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCarros.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }

        public Guid FabricanteId { get; set; }

        public Guid VeiculoId { get; set; }

        public Veiculo? Veiculo { get; set; }

        public Guid UsuarioId { get; set; }

        public decimal ValorVenda { get; set; }

        public string? ClienteNome { get; set; }

        public int ClienteCpf { get; set; }

        public DateTime DataVenda { get; set; }
    }
}
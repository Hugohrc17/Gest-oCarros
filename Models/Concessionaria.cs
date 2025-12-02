using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCarros.Models
{
    public class Concessionaria
    {
        public Guid ConcessionariaId { get; set; }

        public string? Nome { get; set; }

        public string? Rua { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? CEP { get; set; }

        public Veiculo? Veiculos { get; set; }

        public Venda? Vendas { get; set; }

        public Usuario? Usuarios { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
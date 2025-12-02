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

        public Guid UsuarioId { get; set; }

        public int ValorVenda { get; set; }

        public DateTime DataVenda { get; set; }
    }
}
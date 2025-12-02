using GestãoCarros.Models.Enums;

namespace GestãoCarros.Models.Dtos
{
    public class VeiculoDto
    {
        public string? Modelo { get; set; }
        
        public int AnoFabricacao { get; set; }

        public decimal Preco { get; set; }

        public Fabricante? Fabricante { get; set; }

        public TipoVeiculo? Tipo { get; set; }

        public string? Descricao { get; set; }
    }
}
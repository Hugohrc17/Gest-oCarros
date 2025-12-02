using GestãoCarros.Models.Dtos;
using ImobiFlow.Api.Core.Interfaces;

namespace GestãoCarros.Services.Fabricante
{
    public class FabricanteService
    {
        private readonly IRepositorioGenerico _repositorioGenerico;

        public FabricanteService(IRepositorioGenerico repositorioGenerico)
        {
            _repositorioGenerico = repositorioGenerico;
        }

        public async Task<Models.Fabricante?> ObterPorIdAsync(Guid fabricanteId)
        {
            return await _repositorioGenerico.ObterPorIdAsync<Models.Fabricante>(fabricanteId);
        }

        public async Task<IEnumerable<Models.Fabricante>> ObterTodosAsync()
        {
            return await _repositorioGenerico.ObterTodosSemFiltrosAsync<Models.Fabricante>();
        }

        public async Task<Models.Fabricante> AdicionarAsync(Models.Fabricante fabricante)
        {
            return await _repositorioGenerico.AdicionarAsync(fabricante);
        }

        public async Task AtualizarAsync(Guid id, Models.Fabricante fabricante)
        {
            await _repositorioGenerico.AtualizarAsync(fabricante);
        }

        public async Task ExcluirAsync(Guid fabricanteId)
        {
            await _repositorioGenerico.ExcluirAsync<Models.Fabricante>(fabricanteId);
        }

        internal async Task<string?> AdicionarAsync(FabricanteDto fabricanteDto)
        {
            throw new NotImplementedException();
        }

        internal async Task AtualizarAsync(Guid id, FabricanteDto fabricanteDto)
        {
            throw new NotImplementedException();
        }
    }
}
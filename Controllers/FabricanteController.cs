using GestãoCarros.Models;
using GestãoCarros.Models.Dtos;
using GestãoCarros.Services.Fabricante;
using Microsoft.AspNetCore.Mvc;


namespace GestãoCarros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FabricanteController : ControllerBase
    {
        private readonly FabricanteService _fabricanteService;

        public FabricanteController(FabricanteService fabricanteService)
        {
            _fabricanteService = fabricanteService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var fabricantes = await _fabricanteService.ObterTodosAsync();
            return Ok(fabricantes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var fabricante = await _fabricanteService.ObterPorIdAsync(id);
            if (fabricante == null)
            {
                return NotFound();
            }

            return Ok(fabricante);
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(FabricanteDto fabricanteDto)
        {
            var fabricante = await _fabricanteService.AdicionarAsync(fabricanteDto);
            if (fabricante == null)
            {
                return BadRequest("Não foi possível adicionar o fabricante.");
            }

            return Ok(fabricante);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(Guid id, FabricanteDto fabricanteDto)
        {
            var fabricante = await _fabricanteService.ObterPorIdAsync(id);
            if (fabricante == null)
            {
                return NotFound();
            }

            await _fabricanteService.AtualizarAsync(id, fabricanteDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var fabricante = await _fabricanteService.ObterPorIdAsync(id);
            if (fabricante == null)
            {
                return NotFound();
            }

            await _fabricanteService.ExcluirAsync(id);
            return NoContent();
        }
    }
}
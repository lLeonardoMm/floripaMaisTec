using Microsoft.AspNetCore.Mvc;
using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;
using static SalaDeAulaS10.Dto.EstudanteDto;

namespace SalaDeAulaS10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {
        private readonly IEstudanteRepository _estudanteRepository;

        public EstudanteController(IEstudanteRepository estudanteRepository)
        {
            _estudanteRepository = estudanteRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var estudante = _estudanteRepository.ObterLista();

            return Ok(estudante);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var estudante = _estudanteRepository.ObeterPorId(id);

            if (estudante == null)
            {
                return NotFound(id);
            }
            return Ok(estudante);


        }

        [HttpPost]
        public IActionResult Creat([FromBody] EstudanteCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var estudante = new Estudante();
            estudante.RA = dto.RA;
            estudante.Periodo = dto.Periodo;


            _estudanteRepository.Adcionar(estudante);

            var saidaEstudante = new EstudanteSaidaDto();
            saidaEstudante.RA = estudante.RA;
            saidaEstudante.UsuarioId = estudante.UsuarioId;
            saidaEstudante.Id = estudante.Id;
            saidaEstudante.Periodo = estudante.Periodo;


            return CreatedAtAction(nameof(EstudanteController.Get), new { id = estudante.Id }, saidaEstudante);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] EstudanteAlteraçãoDto dto)
        {
            var estudante = _estudanteRepository.ObeterPorId(id);

            if (estudante == null)
            {
                return NotFound(id);
            }

            estudante.Periodo = dto.Periodo;
            estudante.RA = dto.RA;

            _estudanteRepository.Atualizar(estudante);

            return CreatedAtAction(nameof(EstudanteController.Get), new { id = estudante.Id }, estudante);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var estudante = _estudanteRepository.ObeterPorId(id);
            if (estudante == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _estudanteRepository.Excluir(id);
            return NoContent();
        }
    }
}

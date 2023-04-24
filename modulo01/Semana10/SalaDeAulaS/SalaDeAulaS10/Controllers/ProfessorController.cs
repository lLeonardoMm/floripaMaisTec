using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using SalaDeAulaS10.Dto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var professor = _professorRepository.ObterLista();

            return Ok(professor);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var professor = _professorRepository.ObeterPorId(id);

            if (professor == null)
            {
                return NotFound();
            }
            return Ok(professor);


        }

        [HttpPost]
        public IActionResult Creat([FromBody] ProfessorCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var professor = new Professor();
            professor.Departamento = dto.Departamento;
            professor.UsuarioId = dto.UsuarioId;


            _professorRepository.Adcionar(professor);

            return CreatedAtAction(nameof(ProfessorController.Get), new { id = professor.Id }, professor);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] ProfessorCriacaoDto dto)
        {
            var professor = _professorRepository.ObeterPorId(id);

            if (professor == null)
            {
                return NotFound(id);
            }

            professor.Departamento = dto.Departamento;
            professor.UsuarioId = dto.UsuarioId;

            _professorRepository.Atualizar(professor);

            return CreatedAtAction(nameof(ProfessorController.Get), new { id = professor.Id }, professor);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var professor = _professorRepository.ObeterPorId(id);
            if (professor == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _professorRepository.Excluir(id);
            return NoContent();
        }
    }
}

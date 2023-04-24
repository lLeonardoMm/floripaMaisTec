using Microsoft.AspNetCore.Mvc;
using SalaDeAulaS10.Dto;
using SalaDeAulaS10.Migrations;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var disciplina = _disciplinaRepository.ObterLista();

            return Ok(disciplina);
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult Get([FromRoute] int id)
        {
            var disciplina = _disciplinaRepository.ObeterPorId(id);

            if (disciplina == null)
            {
                return NoContent();
            }

            return Ok(disciplina);
        }

        [HttpPost]

        public IActionResult Creat([FromBody] DisciplinaCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var disciplina = new DisciplinaModel();
            disciplina.ProfessorId = dto.ProfessorId;
            disciplina.Materia = dto.Materia;

            _disciplinaRepository.Adcionar(disciplina);

            return CreatedAtAction(nameof(DisciplinaController.Get), new { id = disciplina.Id }, disciplina);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] DisciplinaCriacaoDto dto)
        {
            var disciplina = _disciplinaRepository.ObeterPorId(id);

            if (disciplina == null)
            {
                return NotFound(id);
            }

            disciplina.Materia = dto.Materia;
            disciplina.ProfessorId = dto.ProfessorId;

            _disciplinaRepository.Atualizar(disciplina);

            return CreatedAtAction(nameof(EstudanteController.Get), new { id = disciplina.Id }, disciplina);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var disciplina = _disciplinaRepository.ObeterPorId(id);
            if (disciplina == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _disciplinaRepository.Excluir(id);
            return NoContent();
        }
    }
}


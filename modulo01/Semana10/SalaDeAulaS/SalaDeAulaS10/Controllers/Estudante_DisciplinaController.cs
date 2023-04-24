using Microsoft.AspNetCore.Mvc;
using SalaDeAulaS10.Dto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository;
using SalaDeAulaS10.Repository.InterfaceRepository;
using static SalaDeAulaS10.Dto.EstudanteDto;

namespace SalaDeAulaS10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Estudante_DisciplinaController : ControllerBase
    {

        private readonly IEstudante_DisciplinaRepository _estudante_DisciplinaRepository;

        public Estudante_DisciplinaController(IEstudante_DisciplinaRepository estudante_DisciplinaRepository)
        {
            _estudante_DisciplinaRepository = estudante_DisciplinaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var estudante_Disciplina = _estudante_DisciplinaRepository.ObterLista();

            return Ok(estudante_Disciplina);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var estudante_Disciplina = _estudante_DisciplinaRepository.ObeterPorId(id);

            if (estudante_Disciplina == null)
            {
                return NotFound(id);
            }
            return Ok(estudante_Disciplina);
        }


        [HttpPost]
        public IActionResult Creat([FromBody] Estudante_DisciplinaCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var estudante_Disciplina = new Estudante_Disciplina();
            estudante_Disciplina.DisciplinaId = dto.DisciplinaId;
            estudante_Disciplina.EstudanteId = dto.EstudanteId;


            _estudante_DisciplinaRepository.Adcionar(estudante_Disciplina);


            return CreatedAtAction(nameof(Estudante_DisciplinaController.Get), new { id = estudante_Disciplina.Id }, estudante_Disciplina);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] Estudante_DisciplinaCriacaoDto dto)
        {
            var estudante_Disciplina = _estudante_DisciplinaRepository.ObeterPorId(id);

            if (estudante_Disciplina == null)
            {
                return NotFound(id);
            }

            estudante_Disciplina.DisciplinaId = dto.DisciplinaId;
            estudante_Disciplina.EstudanteId = dto.EstudanteId;

            _estudante_DisciplinaRepository.Atualizar(estudante_Disciplina);

            return CreatedAtAction(nameof(Estudante_DisciplinaController.Get), new { id = estudante_Disciplina.Id }, estudante_Disciplina);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var estudante_Disciplina = _estudante_DisciplinaRepository.ObeterPorId(id);
            if (estudante_Disciplina == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _estudante_DisciplinaRepository.Excluir(id);
            return NoContent();
        }
    }
}

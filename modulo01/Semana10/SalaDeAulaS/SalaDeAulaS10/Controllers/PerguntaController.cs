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
    public class PerguntaController : ControllerBase
    {
        private readonly IPerguntaRepository _perguntaRepository;

        public PerguntaController(IPerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var pergunta = _perguntaRepository.ObterLista();

            return Ok(pergunta);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var pergunta = _perguntaRepository.ObeterPorId(id);

            if (pergunta == null)
            {
                return NotFound();
            }
            return Ok(pergunta);


        }

        [HttpPost]
        public IActionResult Creat([FromBody] PerguntaCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var pergunta = new Pergunta();
            pergunta.Enunciado = dto.Enunciado;
            pergunta.Dificultade = dto.Dificultade;
            pergunta.ProvaId = dto.ProvaId;


            _perguntaRepository.Adcionar(pergunta);

            return CreatedAtAction(nameof(PerguntaController.Get), new { id = pergunta.Id }, pergunta);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] PerguntaCriacaoDto dto)
        {
            var pergunta = _perguntaRepository.ObeterPorId(id);

            if (pergunta == null)
            {
                return NotFound(id);
            }

            pergunta.Enunciado = dto.Enunciado;
            pergunta.Dificultade = dto.Dificultade;
            pergunta.ProvaId = dto.ProvaId;

            _perguntaRepository.Atualizar(pergunta);

            return CreatedAtAction(nameof(PerguntaController.Get), new { id = pergunta.Id }, pergunta);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var pergunta = _perguntaRepository.ObeterPorId(id);
            if (pergunta == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _perguntaRepository.Excluir(id);
            return NoContent();
        }
    }
}


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
    public class RespostaController : ControllerBase
    {
        private readonly IRespostaRepository _respostaRepository;

        public RespostaController(IRespostaRepository respostaRepository)
        {
            _respostaRepository = respostaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var resposta = _respostaRepository.ObterLista();

            return Ok(resposta);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var resposta = _respostaRepository.ObeterPorId(id);

            if (resposta == null)
            {
                return NotFound();
            }
            return Ok(resposta);


        }

        [HttpPost]
        public IActionResult Creat([FromBody] RespostaCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var resposta = new Resposta
            {
                Observacao = dto.Observacao,
                Pontuacao = dto.Pontuacao,
                EstudanteId = dto.EstudanteId,
                PerguntaId = dto.PerguntaId
            };


            _respostaRepository.Adcionar(resposta);

            return CreatedAtAction(nameof(RespostaController.Get), new { id = resposta.Id }, resposta);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] RespostaAlteracaoDto dto)
        {
            var resposta = _respostaRepository.ObeterPorId(id);

            if (resposta == null)
            {
                return NotFound(id);
            }

            resposta.Observacao = dto.Observacao;
            resposta.PerguntaId = dto.PerguntaId;
            

            _respostaRepository.Atualizar(resposta);

            return CreatedAtAction(nameof(RespostaController.Get), new { id = resposta.Id }, resposta);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var resposta = _respostaRepository.ObeterPorId(id);
            if (resposta == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _respostaRepository.Excluir(id);
            return NoContent();
        }
    }
}


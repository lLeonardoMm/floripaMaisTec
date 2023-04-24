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
    public class ProvaController : ControllerBase
    {
        private readonly IProvaRepository _provaRepository;

        public ProvaController(IProvaRepository provaRepository)
        {
            _provaRepository = provaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var prova = _provaRepository.ObterLista();

            return Ok(prova);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var prova = _provaRepository.ObeterPorId(id);

            if (prova == null)
            {
                return NotFound();
            }
            return Ok(prova);


        }

        [HttpPost]
        public IActionResult Creat([FromBody] ProvaCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var prova = new Prova();
            prova.FinalDaProva = dto.FinalDaProva;
            prova.ComecoDaProva = dto.ComecoDaProva;
            prova.DisciplinaId = dto.DisciplinaId;
            prova.Titulo = dto.Titulo;


            _provaRepository.Adcionar(prova);

            return CreatedAtAction(nameof(ProvaController.Get), new { id = prova.Id }, prova);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] ProvaAlteracao dto)
        {
            var prova = _provaRepository.ObeterPorId(id);

            if (prova == null)
            {
                return NotFound(id);
            }

            prova.FinalDaProva = dto.FinalDaProva;
            prova.DisciplinaId = dto.DisciplinaId;
            prova.Titulo = dto.Titulo;

            _provaRepository.Atualizar(prova);

            return CreatedAtAction(nameof(ProvaController.Get), new { id = prova.Id }, prova);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var prova = _provaRepository.ObeterPorId(id);
            if (prova == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _provaRepository.Excluir(id);
            return NoContent();
        }
    }
}
        
   

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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var usuario = _usuarioRepository.ObterLista();

            return Ok(usuario);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var usuario = _usuarioRepository.ObeterPorId(id);

            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);


        }

        [HttpPost]
        public IActionResult Creat([FromBody] UsuarioCriacaoDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var usuario = new Usuario
            {
                Senha = dto.Senha,
                Nome = dto.Nome,
                Email = dto.Email,
            };

            _usuarioRepository.Adcionar(usuario);

            var usuarioSaida = new UsuarioSaidaDto
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
            };

            return CreatedAtAction(nameof(UsuarioController.Get), new { id = usuario.Id }, usuarioSaida);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Uptade(int id, [FromBody] UsuarioAlteracaoDto dto)
        {
            var usuario = _usuarioRepository.ObeterPorId(id);

            if (usuario == null)
            {
                return NotFound(id);
            }

            usuario.Senha = dto.Senha;
            usuario.Nome = dto.Nome;


            _usuarioRepository.Atualizar(usuario);

            return CreatedAtAction(nameof(UsuarioController.Get), new { id = usuario.Id }, usuario);
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var usuario = _usuarioRepository.ObeterPorId(id);
            if (usuario == null)
            {
                return NotFound($"O Id {id} não existe");
            }
            _usuarioRepository.Excluir(id);
            return NoContent();
        }
    }
}

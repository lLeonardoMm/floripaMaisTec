using Microsoft.AspNetCore.Mvc;
using Escola.Models;
using Escolas.Repository;
using Escolas.CriacaoDto;

namespace Escolas.Controllers;

[ApiController]
[Route("Alunos")]
public class AlunoController : ControllerBase
{
    [HttpGet]

    public IActionResult ListarAlunos ([FromQuery] string? nome)
    {
        var repository = new AlunosRepository();
        var listandoAlunos = repository.ListarAluno(nome);

        return Ok(listandoAlunos);
    }

    [HttpGet]
    [Route ("{id}")]
    public IActionResult ObtendoUmAlunoPorId ([FromRoute] int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        var repository = new AlunosRepository();
        var PegandoPorID = repository.ObtendoAlunoPorId(id);
        
        if (PegandoPorID == null)
        {
            return NotFound();
        }

        return Ok(PegandoPorID);
    }

    [HttpPost]
    [Route ("Cadastrando Novo Aluno")]
    public IActionResult CadastrarNovoAluno(CriacaoAluno dto)
    {
        var repository = new AlunosRepository();
        var Cadastrar = repository.CadastrandoAluno(dto);
        return CreatedAtAction(nameof(AlunoController.ObtendoUmAlunoPorId), new { id = Cadastrar.Id }, Cadastrar);
    }
    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir (int id)
    {
        
        var repository = new AlunosRepository();
        repository.ExcluirUmIdAluno(id);
        return NoContent();
    }
}           
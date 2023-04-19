//using Aluno.Repository;
//using Aula02.Dtos;
using Aula02.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula02.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplinaController : ControllerBase
{

    [HttpGet]
    public IActionResult Listar([FromQuery] string? nome)
    {
        var repository = new DisciplinaRepository();
        var disciplinas = repository.ListarDisciplinas(nome);

        return Ok(disciplinas);
    }
}
namespace Aula01.Controllers;
using Aula01.Classe;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Estudantes")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    public IActionResult ObeterInfosAlunos (int id){ 
        
        var alunos = new Aluno();
        alunos.Id = id;
        alunos.DataDeNascimento = new DateTime(1990, 10, 10);
        alunos.Nome = "Leonardo";

        if (id > 10)
        {
           return Ok(alunos.DataDeNascimento);
        };

        return Ok(id);
    }
}
//using Aluno.Repository;
//using Aula01.Classe;
//using Microsoft.AspNetCore.Mvc;

//namespace Aula01.Controllers;

//[ApiController]
//[Route ("Disciplina ")]
// public class DisciplinasController : ControllerBase
//{
//    [HttpGet]
//    [Route("{id}")]
//    public IActionResult ObtendoInfos(int id)
//    {
//        if (id == 0)
//        {
//            return BadRequest();
//        }
//        var repository = new DisciplinaRepository();
//        var Disciplina = repository.Obeterinfos(id);
//        return Ok(Disciplina);
        
//    }
//}
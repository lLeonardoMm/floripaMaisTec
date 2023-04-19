using Aula02.Models;

namespace Aula02.Repositories;

public class DisciplinaRepository
{

    private static List<Disciplina> lista = new List<Disciplina>(){
       new Disciplina { Id = 1, CargaHoraria = 20, Nome = "Hist�ria" },
       new Disciplina { Id = 2, CargaHoraria = 10, Nome = "Hist�ria do Brasil" },
       new Disciplina { Id = 3, CargaHoraria = 25, Nome = "Hist�ria Geral" },
       new Disciplina { Id = 4, CargaHoraria = 20, Nome = "Matem�tica" }
    };

    public List<Disciplina> ListarDisciplinas(string? filtroNome)
    {

        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(z => z.Nome.ToLower().Contains(filtroNome.ToLower()))
            .OrderBy(x => x.Id)
            .ToList();
    }
}



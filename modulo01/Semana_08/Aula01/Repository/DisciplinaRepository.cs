using System.Runtime.InteropServices;
using Aula01.Classe;

namespace Aluno.Repository;

public class DisciplinaRepository
{

    private static List<Disciplina> infos = new List<Disciplina>(){
       new Disciplina { Id = 1, CargaHrr = 20, Nome = "Hist�ria" },
       new Disciplina { Id = 2, CargaHrr = 10, Nome = "Hist�ria do Brasil" },
       new Disciplina { Id = 3, CargaHrr = 25, Nome = "Hist�ria Geral" },
       new Disciplina { Id = 4, CargaHrr = 20, Nome = "Matem�tica" }
    };

    public Disciplina Obeterinfos(int id)
    {
        return infos.FirstOrDefault(i => i.Id == id);

    }
}


    

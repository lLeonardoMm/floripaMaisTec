using System.Collections.Generic;
using Escola.Models;
using Escolas.CriacaoDto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Escolas.Repository;

 public class AlunosRepository
{
    private static List<AlunoModel> Aluno = new List<AlunoModel>()
    {
        new AlunoModel {Id = 1, Nome = "Leonardo",DataDeNascimento = "19-10-2003" },
        new AlunoModel {Id = 2, Nome = "Bruno",   DataDeNascimento = "19-10-2003"  },
        new AlunoModel {Id = 3, Nome = "Martins", DataDeNascimento = "19-10-2003"},
        new AlunoModel {Id = 4, Nome = "Leandro", DataDeNascimento = "19-10-2003"}
    };
    public List<AlunoModel> ListarAluno (string? listaNome)
    {
        if (string.IsNullOrEmpty(listaNome))
        {
            return Aluno;
        }
        else return Aluno.Where(x => x.Nome.ToLower().Contains(listaNome.ToLower())).OrderBy(x => x.Id).ToList(); 
    }
    public AlunoModel? ObtendoAlunoPorId (int id)
    {
        return Aluno.FirstOrDefault(a => a.Id == id);
    }

    public AlunoModel CadastrandoAluno (CriacaoAluno dto)
    {
        var novoAluno = new AlunoModel();
        novoAluno.Id = GerarId();
        novoAluno.DataDeNascimento = dto.DataDeNascimento;
        novoAluno.Nome = dto.Nome;
        novoAluno.DataDeInclusao = DateTime.Now;

        Aluno.Add(novoAluno);
        return novoAluno;

    }
    public void ExcluirUmIdAluno(int id)
    {
        var aluno = Aluno.FirstOrDefault(a => a.Id == id);
        if (aluno != null)
        {
            Aluno.Remove(aluno);
        }
    }

    private int GerarId()
    {
        return Aluno.Last().Id + 1;
    }
}

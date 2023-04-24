using SalaDeAulaS10.Models;

namespace SalaDeAulaS10.Repository.InterfaceRepository
{
    public interface IDisciplinaRepository
    {
        void Adcionar(DisciplinaModel disciplina);
        List<DisciplinaModel> ObterLista();
        DisciplinaModel ObeterPorId(int id);
        void Atualizar(DisciplinaModel disciplina);
        void Excluir(int id);
    }
}

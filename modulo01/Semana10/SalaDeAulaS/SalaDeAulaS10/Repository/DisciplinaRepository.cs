using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly SalaDeAulaContext _context;

        public DisciplinaRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(DisciplinaModel disciplina)
        {
            _context.Disciplinas.Add(disciplina);
            _context.SaveChanges();
        }

        public void Atualizar(DisciplinaModel disciplina)
        {
            _context.Disciplinas.Update(disciplina);
            _context.SaveChanges();
        }

        public DisciplinaModel? ObeterPorId(int id)
        {
            return _context.Disciplinas.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var disciplina = ObeterPorId(id);
            _context.Disciplinas.Remove(disciplina);
            _context.SaveChanges();
        }

        public List<DisciplinaModel> ObterLista()
        {
            return _context.Disciplinas.ToList();
        }
    }
}

using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly SalaDeAulaContext _context;

        public ProfessorRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Professor professor)
        {
            _context.Professores.Add(professor);
            _context.SaveChanges();
        }

        public void Atualizar(Professor professor)
        {
            _context.Professores.Update(professor);
            _context.SaveChanges();
        }

        public Professor ObeterPorId(int id)
        {
            return _context.Professores.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var professor = ObeterPorId(id);
            _context.Professores.Remove(professor);
            _context.SaveChanges();
        }

        public List<Professor> ObterLista()
        {
            return _context.Professores.ToList();
        }
    }
}


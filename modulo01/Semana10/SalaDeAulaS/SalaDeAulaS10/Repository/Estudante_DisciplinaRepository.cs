using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class Estudante_DisciplinaRepository : IEstudante_DisciplinaRepository
    {
        private readonly SalaDeAulaContext _context;

        public Estudante_DisciplinaRepository (SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Estudante_Disciplina estudante_Disciplina)
        {
            _context.Estudante_Disciplinas.Add(estudante_Disciplina);
            _context.SaveChanges();
        }

        public void Atualizar(Estudante_Disciplina estudante_Disciplina)
        {
            _context.Estudante_Disciplinas.Update(estudante_Disciplina);
            _context.SaveChanges();
        }

        public Estudante_Disciplina ObeterPorId(int id)
        {
            return _context.Estudante_Disciplinas.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var estudante_Disciplina = ObeterPorId(id);
            _context.Estudante_Disciplinas.Remove(estudante_Disciplina);
            _context.SaveChanges();
        }

        public List<Estudante_Disciplina> ObterLista()
        {
            return _context.Estudante_Disciplinas.ToList();
        }
    }
}


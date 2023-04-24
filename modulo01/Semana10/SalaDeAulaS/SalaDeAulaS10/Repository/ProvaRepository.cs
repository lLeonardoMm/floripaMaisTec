using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class ProvaRepository : IProvaRepository
    {
        private readonly SalaDeAulaContext _context;

        public ProvaRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Prova prova)
        {
            _context.Provas.Add(prova);
            _context.SaveChanges();
        }

        public void Atualizar(Prova prova)
        {
            _context.Provas.Update(prova);
            _context.SaveChanges();
        }

        public Prova ObeterPorId(int id)
        {
            return _context.Provas.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var provas = ObeterPorId(id);
            _context.Provas.Remove(provas);
            _context.SaveChanges();
        }

        public List<Prova> ObterLista()
        {
            return _context.Provas.ToList();
        }
    }
}

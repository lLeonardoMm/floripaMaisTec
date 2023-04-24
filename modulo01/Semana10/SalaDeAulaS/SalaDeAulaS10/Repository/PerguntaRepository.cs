using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class PerguntaRepository : IPerguntaRepository
    {
        private readonly SalaDeAulaContext _context;

        public PerguntaRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Pergunta pergunta)
        {
            _context.Perguntas.Add(pergunta);
            _context.SaveChanges();
        }

        public void Atualizar(Pergunta pergunta)
        {
            _context.Perguntas.Update(pergunta);
            _context.SaveChanges();
        }

        public Pergunta ObeterPorId(int id)
        {
            return _context.Perguntas.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var perguntas = ObeterPorId(id);
            _context.Perguntas.Remove(perguntas);
            _context.SaveChanges();
        }

        public List<Pergunta> ObterLista()
        {
            return _context.Perguntas.ToList();
        }
    }
}


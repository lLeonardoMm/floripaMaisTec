using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class RespostaRepository : IRespostaRepository
    {
        private readonly SalaDeAulaContext _context;

        public RespostaRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Resposta resposta)
        {
            _context.Respostas.Add(resposta);
            _context.SaveChanges();
        }

        public void Atualizar(Resposta resposta)
        {
            _context.Respostas.Update(resposta);
            _context.SaveChanges();
        }

        public Resposta ObeterPorId(int id)
        {
            return _context.Respostas.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var resposta = ObeterPorId(id);
            _context.Respostas.Remove(resposta);
            _context.SaveChanges();
        }

        public List<Resposta> ObterLista()
        {
            return _context.Respostas.ToList();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class EstudanteRepository : IEstudanteRepository
    {
        private readonly SalaDeAulaContext _context;

        public EstudanteRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Estudante estudante)
        {
            _context.Estudantes.Add(estudante);
            _context.SaveChanges();
        }

        public void Atualizar(Estudante estudante)
        {
            _context.Estudantes.Update(estudante);
            _context.SaveChanges();
        }

        public Estudante ObeterPorId(int id)
        {
             return _context.Estudantes.FirstOrDefault(e => e.Id.Equals(id)); 
        }

        public void Excluir(int id)
        {
            var estudante = ObeterPorId(id);
            _context.Estudantes.Remove(estudante);
            _context.SaveChanges();
        }

        public List<Estudante> ObterLista()
        {
            return _context.Estudantes.ToList();
        }
    }
}

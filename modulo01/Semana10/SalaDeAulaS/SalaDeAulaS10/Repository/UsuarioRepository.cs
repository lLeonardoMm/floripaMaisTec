using SalaDeAulaS10.Contexto;
using SalaDeAulaS10.Models;
using SalaDeAulaS10.Repository.InterfaceRepository;

namespace SalaDeAulaS10.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SalaDeAulaContext _context;

        public UsuarioRepository(SalaDeAulaContext context)
        {
            _context = context;
        }
        public void Adcionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public Usuario ObeterPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Excluir(int id)
        {
            var usuario = ObeterPorId(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> ObterLista()
        {
            return _context.Usuarios.ToList();
        }
    }
}

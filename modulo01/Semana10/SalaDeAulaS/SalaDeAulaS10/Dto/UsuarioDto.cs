namespace SalaDeAulaS10.Dto
{
    public class UsuarioCriacaoDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
    public class UsuarioSaidaDto
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email { get; set; }

    }
    public class UsuarioAlteracaoDto
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

    }
}

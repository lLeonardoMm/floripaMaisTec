namespace SalaDeAulaS10.Models
{
    public class Resposta
    {
        public int Id { get; set; }
        public int PerguntaId { get; set; }
        public int EstudanteId { get; set; }
        public string Respostas { get; set; }
        public float Pontuacao { get; set; }
        public string? Observacao { get; set; }
    }
}

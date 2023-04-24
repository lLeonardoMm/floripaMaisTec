namespace SalaDeAulaS10.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public int ProvaId { get; set; }
        public string Enunciado { get; set; }
        public decimal? Dificultade { get; set; }
    }
}

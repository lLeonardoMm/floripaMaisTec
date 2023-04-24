namespace SalaDeAulaS10.Models
{
    public class Prova
    {
        public int Id { get; set; }
        public int DisciplinaId { get; set; }
        public string? Titulo { get; set; }
        public DateTime ComecoDaProva { get; set; }
        public DateTime FinalDaProva { get; set; }
    }
}

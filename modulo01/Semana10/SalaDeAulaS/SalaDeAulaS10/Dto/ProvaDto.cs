namespace SalaDeAulaS10.Dto
{
    public class ProvaCriacaoDto
    {
        public int DisciplinaId { get; set; }
        public string? Titulo { get; set; }
        public DateTime ComecoDaProva { get; set; }
        public DateTime FinalDaProva { get; set; }
    }
    public class ProvaAlteracao
    {
        public int DisciplinaId { get; set; }
        public string? Titulo { get; set; }
        public DateTime FinalDaProva { get; set; }

    }
}

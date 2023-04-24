namespace SalaDeAulaS10.Dto
{
    public class RespostaCriacaoDto
    {
        public int PerguntaId { get; set; }
        public int EstudanteId { get; set; }
        public string Respostas { get; set; }
        public float Pontuacao { get; set; }
        public string? Observacao { get; set; }
    }
    public class RespostaAlteracaoDto
    {
        public int PerguntaId { get; set; }
        public string? Observacao { get; set; }
    }
}

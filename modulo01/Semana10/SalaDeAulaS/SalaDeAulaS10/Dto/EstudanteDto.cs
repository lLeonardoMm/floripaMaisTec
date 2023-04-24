namespace SalaDeAulaS10.Dto
{
    public class EstudanteDto
    {
        public class EstudanteCriacaoDto
        {
            public int Periodo { get; set; }
            public int RA { get; set; }

        }

        public class EstudanteSaidaDto
        {
            public int Id { get; set; }
            public int Periodo { get; set; }
            public int UsuarioId { get; set; }
            public int RA { get; set; }
        }

        public class EstudanteAlteraçãoDto
        {
            public int Periodo { get; set; }
            public int RA { get; set; }
            

        }
    }
}

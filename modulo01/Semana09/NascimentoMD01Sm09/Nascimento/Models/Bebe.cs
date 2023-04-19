using System.ComponentModel.DataAnnotations.Schema;

namespace bercario.Models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Decimal PesoDeNascimento { get; set; }
        public int Altura { get; set; }

        //[ForeignKey("Endereco_qId")] Só Para demostrar como é uma Anotação quando é uma FK
        public int IdDeMae { get; set; }
        public int IdDoParto { get; set; }

        public virtual Mae MaeBebe { get; set; }
        public virtual Parto PartoBebe { get; set; }
    }
}

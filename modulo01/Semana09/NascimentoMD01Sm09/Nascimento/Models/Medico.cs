using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bercario.Models
{
    //[Table ("Medico")]   Não vou Fazer tudo em Anotação pois Acho que polui muito e me perco tudo
    public class Medico
    {
        //[Key]
        //[Column("Id_Medico")]
        //[Required]
        public int Id { get; set; }
        //[Column("CRM")]
        //[StringLength(15)]
        //[Required]
        public string CRM { get; set; }
        //[Column("Nome")]
        //[StringLength(60)]
        //[Required]
        public string Nome { get; set; }
        //[Column("Especialidade")]
        //[StringLength(100)]
        //[Required]
        public string Especialidade { get; set; }
        //[Column("Celular")]
        public int Celular { get; set; }

        //Virtual
        public virtual ICollection<Parto> Partos { get; set; }
    }
}

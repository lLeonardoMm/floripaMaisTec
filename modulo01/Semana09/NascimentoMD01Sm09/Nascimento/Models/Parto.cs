using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bercario.Models
{
    public class Parto
    { 
        public int Id { get; set; }
        public DateTime DataDoParto { get; set; }
        public DateTime HorarioDoParto { get; set; }
        public int IdDoMedico { get; set; }

        public virtual ICollection<Bebe> Bebes { get; set;}
        public virtual Medico MedicoParto { get; set; }
    }
}

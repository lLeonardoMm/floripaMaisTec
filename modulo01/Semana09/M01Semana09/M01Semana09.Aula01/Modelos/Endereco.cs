using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M01Semana09.Aula01.Modelos
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Numero")]
        [StringLength(20)]
        [Required]
        public string Numero { get; set; }
        [Column("Logradouro")]
        [StringLength(60)]
        [Required]
        public string Logradouro{ get; set; }
        [Column("Bairro")]
        [StringLength(60)]
        [Required]
        public string Bairro{ get; set; }
        [Column("Cidade")]
        [StringLength(60)]
        [Required]
        public string Cidade { get; set; }

        public virtual Cliente Clientes { get; set; }
    }
}

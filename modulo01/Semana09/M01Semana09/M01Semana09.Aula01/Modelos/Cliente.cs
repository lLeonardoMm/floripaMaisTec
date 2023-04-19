using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M01Semana09.Aula01.Modelos
{
    [Table ("Cliente")]
    public class Cliente
    {
        [Key]
        [Column ("user_id")]
        [Required]
        public int Id { get; set; }
        [Column("Name")]
        [StringLength(60)]
        [Required]
        public string Nome { get; set; }
        [ForeignKey("Endereco_qId")]
        public virtual Endereco EnderecoId { get; set; }

        //props virtuais
        public virtual ICollection<Compra> Compras { get; set; }
    }
}

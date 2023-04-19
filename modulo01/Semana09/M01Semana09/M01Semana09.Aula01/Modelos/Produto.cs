using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M01Semana09.Aula01.Modelos
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Name")]
        [StringLength(60)]
        [Required]
        public string Nome { get; set; }
        [Column("Categoria")]
        [StringLength(200)]
        [Required]
        public string Categoria { get; set; }
        [Column("PrecoUnitario", TypeName = "Decimal (9,2)")]
        [Required]
        public double PrecoUnitario { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<PromocaoProduto> ProdutosPromoces { get; set; }


    }
}

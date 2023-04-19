using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M01Semana09.Aula01.Modelos
{
    [Table("Compra")]
    public class Compra
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Quantidade")]
        [Required]
        public int Quantidade { get; set; }
        [Column("Preco")]
        [Required]
        public int Preco { get; set; }
        [Column("Cliente_Id")]
        [Required]
        public int ClienteId { get; set; }
        [Column("Produto_Id")]
        [Required]
        public int ProdutoId { get; set; }

        [ForeignKey("Cliente_Id")]
        public virtual Cliente ClienteCompra { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto ProdutoCompra { get; set; }

    }
}

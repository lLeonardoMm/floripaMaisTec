using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M01Semana09.Aula01.Modelos
{
    [Table("PromocaoProdutoFK")]
    public class PromocaoProduto
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [ForeignKey("Produto_Id")]
        [Required]
        public virtual Produto ProdutoId { get; set; }
        [ForeignKey("Promocao_Id")]
        public virtual Promocao PromocaoId { get; set; }
    
    }
}

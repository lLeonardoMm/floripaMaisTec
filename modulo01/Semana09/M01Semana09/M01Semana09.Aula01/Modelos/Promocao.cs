using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M01Semana09.Aula01.Modelos
{
    [Table ("Promoção")]
    public class Promocao
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Descricao")]
        [Required]
        public string Descricao { get; set; }
        [Column("DataInicio")]
        [Required]
        public DateTime DataDeInicio { get; set; }
        [Column("DataTermino")]
        [Required]
        public DateTime DataDeTermino { get; set; }
        public virtual ICollection<PromocaoProduto> PromocoesProdutos { get; set; }
    }
}

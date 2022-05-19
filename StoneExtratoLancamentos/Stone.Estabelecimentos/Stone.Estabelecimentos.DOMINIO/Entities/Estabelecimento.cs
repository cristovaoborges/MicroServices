using Stone.Estabelecimentos.DOMINIO.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stone.Estabelecimentos.DOMINIO.Entities
{
    [Table("TB_ESTABELECIMENTO")]
    public class Estabelecimento
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("nome_estabelecimento")]
        [Required]
        [StringLength(150)]
        public string NomeEstabelecimento { get; set; }
        [Column("classificacao")]
        public ClassificacaoEstabelecimento? Classificacao { get; set; }
        

    }
}

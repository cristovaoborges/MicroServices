using Stone.Lancamentos.DOMINIO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Lancamentos.DOMINIO.Entities
{
    [Table("TB_LANCAMENTO")]
    public class Lancamento
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [DataType(DataType.Date)]
        [Column("data_referencia")]
        public DateTime DataReferencia { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        [Column("estabelecimento")]
        public string Estabelecimento { get; set; }        
        public decimal Valor { get; set; }
    }
}

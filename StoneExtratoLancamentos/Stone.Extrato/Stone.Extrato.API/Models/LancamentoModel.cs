using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stone.Extrato.API.Models
{
    public class LancamentoModel
    {
       
        public long Id { get; set; }       
        public DateTime DataReferencia { get; set; }
        public int FormaPagamento { get; set; }        
        public string Estabelecimento { get; set; }
        public decimal Valor { get; set; }
    }
}

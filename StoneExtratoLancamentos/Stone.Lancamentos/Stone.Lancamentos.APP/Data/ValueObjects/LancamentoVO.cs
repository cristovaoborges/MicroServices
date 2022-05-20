using Stone.Lancamentos.DOMINIO.Enums;
using StoneMessage.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Lancamentos.APP.Data.ValueObjects
{
    public class LancamentoVO :BaseEvent
    {
       
        public long Id { get; set; }    
        
        public DateTime DataReferencia { get; set; }
        public FormaPagamento FormaPagamento { get; set; }        
        public string Estabelecimento { get; set; }
        public decimal Valor { get; set; }
    }
}

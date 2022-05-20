using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneMessage.Events
{
    public class LancamentoEvent : BaseEvent
    {
       
        public DateTime DataReferencia { get; set; }
        public string FormaPagamento { get; set; }
        public string Estabelecimento { get; set; }
        public decimal Valor { get; set; }
    }
}

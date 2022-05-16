
using Stone.Estabelecimentos.DOMINIO.Enums;

namespace Stone.Estabelecimentos.APP.Data.ValueObjects
{
    public class EstabelecimentoVO
    {

       
        public long Id { get; set; }        
        public string NomeEstabelecimento { get; set; }       
        public ClassificacaoEstabelecimento? Classificacao { get; set; }
    }
}

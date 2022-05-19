
using Stone.Extrato.API.Models;
using Stone.Extrato.API.Services.IServices;
using Stone.Extrato.API.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stone.Extrato.API.Services
{
    public class LancamentoService : ILancamentoService
    {

        private readonly HttpClient _client;
        private const string BasePath = "api/v1/Lancamento";

        public LancamentoService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<LancamentoModel>> FindAllLancamentos()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<LancamentoModel>>();
        }

        public async Task<IEnumerable<LancamentoModel>> RelatorioGeral()
        {

            
            var result = new List<LancamentoModel>();

            
            HttpResponseMessage response = new HttpResponseMessage();
            response = await _client.GetAsync(BasePath);
           var lancamentos =  await response.ReadContentAs<List<LancamentoModel>>();
            

            var somaagregada = (from t in lancamentos
                         group t by new {t.FormaPagamento ,t.Estabelecimento}
             into grupo
                         select new
                         {
                             
                             grupo.Key.FormaPagamento,
                             grupo.Key.Estabelecimento,
                             Valor = grupo.Sum(t => t.Valor)
                         }).ToList();

            foreach (var item in somaagregada)
            {
                var ValorLista = new LancamentoModel();
               // ValorLista.DataReferencia = item.DataReferencia;
                ValorLista.Estabelecimento = item.Estabelecimento;
                ValorLista.FormaPagamento = item.FormaPagamento;
                ValorLista.Valor = item.Valor;

                result.Add(ValorLista);
            }

            
            
            return result;
        }
            
            
        

    }
}

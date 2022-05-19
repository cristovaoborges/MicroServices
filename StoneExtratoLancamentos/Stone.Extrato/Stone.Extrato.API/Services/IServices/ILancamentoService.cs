using Stone.Extrato.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stone.Extrato.API.Services.IServices
{
    public interface ILancamentoService
    {
        Task<IEnumerable<LancamentoModel>> FindAllLancamentos();
        Task<IEnumerable<LancamentoModel>> RelatorioGeral();
    }
}

using Stone.Lancamentos.APP.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Lancamentos.APP.Repository.Interfaces
{
   public interface ILancamentoRepository
    {
        Task<IEnumerable<LancamentoVO>> FindAll();
        Task<LancamentoVO> FindById(long id);
        Task<LancamentoVO> Create(LancamentoVO vo);
        Task<LancamentoVO> Update(LancamentoVO vo);
        Task<bool> Delete(long id);
    }
}

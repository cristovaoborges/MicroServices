using Stone.Estabelecimentos.APP.Data.ValueObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stone.Estabelecimentos.APP.Repository.Interfaces
{
    public interface IEstabelecimentoRepository
    {
        Task<IEnumerable<EstabelecimentoVO>> FindAll();
        Task<EstabelecimentoVO> FindById(long id);
        Task<EstabelecimentoVO> Create(EstabelecimentoVO vo);
        Task<EstabelecimentoVO> Update(EstabelecimentoVO vo);
        Task<bool> Delete(long id);
    }
}

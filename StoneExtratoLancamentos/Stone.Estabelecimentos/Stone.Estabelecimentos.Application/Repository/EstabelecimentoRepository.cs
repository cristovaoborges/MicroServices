using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Stone.Estabelecimentos.APP.Data.ValueObjects;
using Stone.Estabelecimentos.APP.Repository.Interfaces;
using Stone.Estabelecimentos.DOMINIO.Entities;
using Stone.Estabelecimentos.INFRA.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stone.Estabelecimentos.APP.Repository
{
    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {

        private readonly SqlServerContext _context;
        private IMapper _mapper;

        public EstabelecimentoRepository(SqlServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<IEnumerable<EstabelecimentoVO>> FindAll()
        {
            List<Estabelecimento> estacelecimento = await _context.Estabelecimentos.ToListAsync();
            return _mapper.Map<List<EstabelecimentoVO>>(estacelecimento);
        }

        public async Task<EstabelecimentoVO> FindById(long id)
        {
            Estabelecimento estacelecimento = await _context.Estabelecimentos.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<EstabelecimentoVO>(estacelecimento);

        }

        public async Task<EstabelecimentoVO> Create(EstabelecimentoVO vo)
        {
            Estabelecimento estabelecimento = _mapper.Map<Estabelecimento>(vo);
            _context.Estabelecimentos.Add(estabelecimento);
            await _context.SaveChangesAsync();

            return _mapper.Map<EstabelecimentoVO>(estabelecimento);
        }

        public async Task<EstabelecimentoVO> Update(EstabelecimentoVO vo)
        {
            Estabelecimento estabelecimento = _mapper.Map<Estabelecimento>(vo);
            _context.Estabelecimentos.Update(estabelecimento);
            await _context.SaveChangesAsync();

            return _mapper.Map<EstabelecimentoVO>(estabelecimento);
        }


        public async Task<bool> Delete(long id)
        {
            try
            {
                Estabelecimento estabelecimento = await _context.Estabelecimentos.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (estabelecimento == null) return false;
               _context.Estabelecimentos.Remove(estabelecimento);
                await _context.SaveChangesAsync();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }

       

        

       
    }
}

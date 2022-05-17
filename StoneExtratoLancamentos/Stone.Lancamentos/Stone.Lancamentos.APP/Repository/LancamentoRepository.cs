using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Stone.Lancamentos.APP.Data.ValueObjects;
using Stone.Lancamentos.APP.Repository.Interfaces;
using Stone.Lancamentos.DOMINIO.Entities;
using Stone.Lancamentos.INFRA.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Lancamentos.APP.Repository
{
    public class LancamentoRepository : ILancamentoRepository
    {

        private readonly SqlServerContext _context;
        private IMapper _mapper;

        public LancamentoRepository(SqlServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<LancamentoVO> Create(LancamentoVO vo)
        {
            Lancamento lancamento = _mapper.Map<Lancamento>(vo);
            _context.Lancamentos.Add(lancamento);
            await _context.SaveChangesAsync();

            return _mapper.Map<LancamentoVO>(lancamento);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Lancamento lancamento = await _context.Lancamentos.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (lancamento == null) return false;
                _context.Lancamentos.Remove(lancamento);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<LancamentoVO>> FindAll()
        {
            List<Lancamento> lancamentos = await _context.Lancamentos.ToListAsync();
            return _mapper.Map<List<LancamentoVO>>(lancamentos);


        }

        public async Task<LancamentoVO> FindById(long id)
        {
            Lancamento lancamento = await _context.Lancamentos.Where(l => l.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<LancamentoVO>(lancamento);
        }

        public async Task<LancamentoVO> Update(LancamentoVO vo)
        {
            Lancamento lancamento = _mapper.Map<Lancamento>(vo);
            _context.Lancamentos.Update(lancamento);
            await _context.SaveChangesAsync();

            return _mapper.Map<LancamentoVO>(lancamento);
        }
    }
}

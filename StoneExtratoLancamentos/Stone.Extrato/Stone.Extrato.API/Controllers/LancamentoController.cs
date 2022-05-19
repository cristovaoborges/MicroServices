using Microsoft.AspNetCore.Mvc;
using Stone.Extrato.API.Models;
using Stone.Extrato.API.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stone.Extrato.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LancamentoController: ControllerBase
    {
        private readonly ILancamentoService _lancamentoService;

        
        public LancamentoController(ILancamentoService lancamentoService)
        {
            _lancamentoService = lancamentoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LancamentoModel>>> FindAll()
        {

            var lancamentos = await _lancamentoService.FindAllLancamentos();
            return Ok(lancamentos);
        }

        [Route("extrato-consolidado")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LancamentoModel>>> FindAllB()
        {

            var lancamentos = await _lancamentoService.RelatorioGeral();
            return Ok(lancamentos);
        }

    }
}

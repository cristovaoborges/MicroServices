﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stone.Lancamentos.APP.Data.ValueObjects;
using Stone.Lancamentos.APP.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stone.Lancamentos.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {

        private ILancamentoRepository _repository;

        public LancamentoController(ILancamentoRepository repository)
        {
            _repository = repository;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LancamentoVO>>> FindAll()
        {

            var lancamentos = await _repository.FindAll();
            return Ok(lancamentos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<LancamentoVO>> FindById(long id)
        {
            var lancamento = await _repository.FindById(id);
            if (lancamento == null) return NotFound();
            return Ok(lancamento);
        }

        [HttpPost]
        public async Task<ActionResult<LancamentoVO>> Create([FromBody] LancamentoVO vo)
        {
            if (vo == null) return BadRequest();
            var lancamento = await _repository.Create(vo);
            return Ok(lancamento);
        }

        [HttpPut]
        public async Task<ActionResult<LancamentoVO>> Update([FromBody] LancamentoVO vo)
        {
            if (vo == null) return BadRequest();
            var lancamento = await _repository.Update(vo);
            return Ok(lancamento);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);

        }
    }
}

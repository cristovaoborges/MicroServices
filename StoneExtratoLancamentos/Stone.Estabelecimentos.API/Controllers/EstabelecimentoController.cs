using Microsoft.AspNetCore.Mvc;
using Stone.Estabelecimentos.APP.Data.ValueObjects;
using Stone.Estabelecimentos.APP.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stone.Estabelecimentos.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private IEstabelecimentoRepository _repository;

        public EstabelecimentoController(IEstabelecimentoRepository repository)
        {
            _repository = repository;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstabelecimentoVO>>> FindAll(){

            var estabelecimentos = await _repository.FindAll();
            return Ok(estabelecimentos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EstabelecimentoVO>> FindById(long id)
        {
            var estabelecimento = await _repository.FindById(id);
            if (estabelecimento == null) return NotFound();
            return Ok(estabelecimento);
        }

        [HttpPost]
        public async Task<ActionResult<EstabelecimentoVO>> Create([FromBody]EstabelecimentoVO vo)
        {
            if (vo == null) return BadRequest();
            var estabelecimento = await _repository.Create(vo);
            return Ok(estabelecimento);
        }

        [HttpPut]
        public async Task<ActionResult<EstabelecimentoVO>> Update([FromBody] EstabelecimentoVO vo)
        {
            if (vo == null) return BadRequest();
            var estabelecimento = await _repository.Update(vo);
            return Ok(estabelecimento);
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

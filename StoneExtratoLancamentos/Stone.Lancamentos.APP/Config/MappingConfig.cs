using AutoMapper;
using Stone.Lancamentos.APP.Data.ValueObjects;
using Stone.Lancamentos.DOMINIO.Entities;

namespace Stone.Lancamentos.APP.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<LancamentoVO, Lancamento>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}

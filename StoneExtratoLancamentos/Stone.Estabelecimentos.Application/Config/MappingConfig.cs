using AutoMapper;
using Stone.Estabelecimentos.APP.Data.ValueObjects;
using Stone.Estabelecimentos.DOMINIO.Entities;

namespace Stone.Estabelecimentos.APP.Config
{
   public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<EstabelecimentoVO, Estabelecimento>().ReverseMap();
                
            });

            return mappingConfig;
        }
    }
}

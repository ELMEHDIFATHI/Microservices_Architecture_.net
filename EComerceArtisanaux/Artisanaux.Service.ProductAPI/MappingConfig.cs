using Artisanaux.Service.ProductAPI.Models;
using Artisanaux.Service.ProductAPI.Models.Dto;
using AutoMapper;

namespace Artisanaux.Service.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product,ProductDto>();

            });
            {
                return mappingConfig;

            }
        }






    }
}

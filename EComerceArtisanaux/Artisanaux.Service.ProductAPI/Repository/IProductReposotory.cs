using Artisanaux.Service.ProductAPI.Models.Dto;

namespace Artisanaux.Service.ProductAPI.Repository
{
    public interface IProductReposotory
    {
        Task<IEnumerable<ProductDto>> GetProductDtos();

        Task<ProductDto> GetProductByID(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto product);

        Task<bool> DeleteProduct(int productId);
    }
}

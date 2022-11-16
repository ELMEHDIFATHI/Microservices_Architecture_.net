using Artisanaux.Service.ProductAPI.DbContexts;
using Artisanaux.Service.ProductAPI.Models.Dto;

namespace Artisanaux.Service.ProductAPI.Repository
{
    public class ProductReposotory : IProductReposotory
    {

        private readonly ApplicationDbContext _db;
        public Task<ProductDto> CreateUpdateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductByID(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProductDtos()
        {
            throw new NotImplementedException();
        }
    }
}

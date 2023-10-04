using CP2.Models;
using CP2.Models.Dto;

namespace CP2.Interfaces
{
    public interface IProductService
    {
        List<Product> getAllProducts();
        Product create(ProductDto productDto);
        Product? update(Product product);
        Product? findByGuid(Guid guid);
        void delete(Guid guid);
    }
}

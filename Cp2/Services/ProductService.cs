using CP2.Interfaces;
using CP2.Models;
using CP2.Models.Dto;
using CP2.Models.Enum;

namespace CP2.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product> () { new Product () { Guid = Guid.NewGuid(), Name = "TesteN", Description = "TesteD", Price = 120, Quantity = 2, ProductType = ProductType.OUTRO } };
        public Product create(ProductDto productDto)
        {
            Product product = productDto.ToProduct();

            _products.Add(product);

            return product;
        }

        public void delete(Guid guid)
        {
            int index = _products.FindIndex(x => x.Guid == guid);

            if(index == -1)
            {
                return;
            }

            _products.RemoveAt(index);
        }

        public Product? findByGuid(Guid guid)
        {
            return _products.Find(x => x.Guid == guid);
        }

        public List<Product> getAllProducts()
        {
            return _products;
        }

        public Product? update(Product product)
        {
            int index = _products.FindIndex(x => x.Guid == product.Guid);

            if(index == -1) 
            {
                return null;
            }

            _products[index] = product;

            return _products[index];
        }
    }
}

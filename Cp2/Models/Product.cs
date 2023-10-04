using CP2.Models.Dto;
using CP2.Models.Enum;

namespace CP2.Models
{
    public class Product
    {
        public Guid Guid { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public int? Quantity { get; set; }

        public ProductType ProductType { get; set; }
    }

    public static class ProductDtoExtensions
    {
        public static Product ToProduct (this ProductDto productDto)
        {
            return new Product() { 
                Guid = Guid.NewGuid(), 
                Name = productDto.Name, 
                Description = productDto.Description, 
                Price = productDto.Price, 
                Quantity = productDto.Quantity, 
                ProductType = productDto.ProductType
            };
        }
    }
}

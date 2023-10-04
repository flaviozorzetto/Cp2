using CP2.Models.Enum;

namespace CP2.Models.Dto
{
    public class ProductDto
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public int? Quantity { get; set; }

        public ProductType ProductType { get; set; }
    }
}

using Domain.Models.Product;
using Service.Dto;

namespace Service.Mapper
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(this Product a)
        {
            return new ProductDto
            {
                Id = a.Id,
                Name = a.Name,
                Price = a.Price,
            };
        }

        public static Product ToModel(this ProductCreateDto a)
        {
            return new Product(a.Name, a.Price);
        }
    }
}

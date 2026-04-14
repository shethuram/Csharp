using System.ComponentModel.DataAnnotations;

namespace ProductApi.Dto
{
    public class UpdateProductDto
    {
        [MinLength(1)]
        public required string Name { get; set; }

        [Range(1, 1000000)]
        public decimal Price { get; set; }

        [Range(0, 10000)]
        public int Stock { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int Id { get; init; }
        [Required(ErrorMessage = "ProductName is Required")]
        public String? ProductName { get; init; } = String.Empty;
        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; init; }
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; } = String.Empty;
        public int? CategoryId { get; init; }
    }
}
namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProducts;

public class CreateProductResponse
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

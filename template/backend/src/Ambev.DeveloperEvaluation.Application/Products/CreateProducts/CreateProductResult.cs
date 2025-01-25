namespace Ambev.DeveloperEvaluation.Application.Products.CreateProducts;

public class CreateProductResult
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

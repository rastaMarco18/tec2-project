using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProducts;

public class CreateProductCommand : IRequest<CreateProductResult>
{
    public decimal Price{ get; set; }
    public string Name { get; set; }
}
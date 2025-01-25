using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProducts;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Name).NotEmpty().Length(3, 100);
        RuleFor(product => product.Price).NotEmpty().NotEqual(0);
    }
}
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.TotalSale).NotEmpty().NotEqual(0);
        RuleFor(sale => sale.TotalSaleItems).NotEmpty().NotEqual(0);
        RuleForEach(x => x.Products).ChildRules(product =>
        {
            product.RuleFor(p => p.ProductId).NotEqual(Guid.Empty).WithMessage("The product Id should not be empty");
            product.RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("the quantity should be more than 0");
        });
        RuleFor(x => x.Products)
            .Must(NotSellPlus20)
            .WithMessage("There are more than 20 identical items");
    }

    private bool NotSellPlus20(List<ProductQuantityRequest> Products)
    {
        return !Products.Any(p => p.Quantity > 20);
    }
}

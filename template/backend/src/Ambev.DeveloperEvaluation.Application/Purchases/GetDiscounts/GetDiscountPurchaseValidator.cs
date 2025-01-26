using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts;

public class GetDiscountPurchaseValidator : AbstractValidator<GetDiscountPurchaseCommand>
{
    public GetDiscountPurchaseValidator()
    {
        RuleForEach(x => x.Products).ChildRules(product =>
        {
            product.RuleFor(p => p.ProductId).NotEqual(Guid.Empty).WithMessage("The product Id should not be empty");
            product.RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("the quantity should be more than 0");
        });
        RuleFor(x => x.Products)
            .Must(NotSellPlus20)
            .WithMessage("There are more than 20 identical items");
    }

    private bool NotSellPlus20(List<ProductPurchaseCommand> Products)
    {
      return !Products.Any(p => p.Quantity > 20);
    }
}
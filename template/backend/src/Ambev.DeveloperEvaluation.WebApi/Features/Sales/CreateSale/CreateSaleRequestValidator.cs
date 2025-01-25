using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.TotalSale).NotEmpty().NotEqual(0);
        RuleFor(sale => sale.TotalSaleItems).NotEmpty().NotEqual(0);
    }
}

using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelSales;

public class CancelSaleValidator : AbstractValidator<CancelSaleCommand>
{
    public CancelSaleValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Sale ID is required");
    }

}
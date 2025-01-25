using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales
{
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {
        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.TotalSale).NotEmpty().NotEqual(0);
            RuleFor(sale => sale.TotalSaleItems).NotEmpty().NotEqual(0);
        }
    }
}
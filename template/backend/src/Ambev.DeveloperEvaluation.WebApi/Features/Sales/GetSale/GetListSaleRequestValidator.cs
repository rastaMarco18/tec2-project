using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    public class GetListSaleRequestValidator : AbstractValidator<GetSaleRequest>
    {
        public GetListSaleRequestValidator()
        {
            RuleFor(x => x.PageNumber)
                .NotEmpty()
                .WithMessage("PageNumber is Required");

            RuleFor(x => x.PageSize)
                .NotEmpty()
                .WithMessage("PageSize is Required");
        }
    }
}

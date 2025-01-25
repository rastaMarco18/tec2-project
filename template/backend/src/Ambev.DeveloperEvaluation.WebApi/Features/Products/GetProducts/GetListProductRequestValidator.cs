using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts
{
    public class GetListProductRequestValidator : AbstractValidator<GetProductRequest>
    {
        public GetListProductRequestValidator()
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
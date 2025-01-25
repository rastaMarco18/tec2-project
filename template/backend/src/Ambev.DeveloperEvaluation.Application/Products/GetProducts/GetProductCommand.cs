using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts
{
    public class GetProductCommand : IRequest<GetProductResult>
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal? Price { get; set; }
    }
}
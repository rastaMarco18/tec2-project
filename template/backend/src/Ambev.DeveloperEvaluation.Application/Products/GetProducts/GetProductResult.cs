using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts
{
    public class GetProductResult
    {
        public IQueryable<Product>? Products { get; set; }
    }
}

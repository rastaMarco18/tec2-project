namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts
{
    public class GetProductRequest
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal? Price { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}

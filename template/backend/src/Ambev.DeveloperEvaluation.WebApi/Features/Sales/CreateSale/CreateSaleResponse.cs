namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal TotalSale { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSaleItems { get; set; }
        public bool Canceled { get; set; }
    }
}

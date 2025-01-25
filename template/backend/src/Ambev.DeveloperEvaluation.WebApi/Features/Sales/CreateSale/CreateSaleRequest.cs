namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequest
    {
        public decimal TotalSale { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSaleItems { get; set; }
    }
}

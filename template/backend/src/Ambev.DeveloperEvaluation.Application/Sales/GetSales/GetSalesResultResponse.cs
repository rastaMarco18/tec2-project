namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    public class GetSalesResultResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalSale { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSaleItems { get; set; }
        public bool Canceled { get; set; }
    }
}

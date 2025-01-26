using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelSales
{
    public class CancelSaleProfile : Profile
    {
        public CancelSaleProfile() 
        {
            CreateMap<CancelSaleResult, CancelSaleCommand>().ReverseMap();
        }
    }
}

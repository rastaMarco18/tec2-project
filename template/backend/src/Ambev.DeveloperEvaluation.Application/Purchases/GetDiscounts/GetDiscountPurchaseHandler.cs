using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts;

public class GetDiscountPurchaseHandler : IRequestHandler<GetDiscountPurchaseCommand, GetDiscountPurchaseResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetDiscountPurchaseHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<GetDiscountPurchaseResult> Handle(GetDiscountPurchaseCommand request, CancellationToken cancellationToken)
    {
        var validator = new GetDiscountPurchaseValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        bool discount10 = await GetDiscount10(request);
        bool discount20 = await GetDiscount20(request);
        decimal discount = 0;
        if (discount20 && discount10)
            discount = (decimal)0.30; //I don't know if it could be like that
        else if (!discount20 && discount10) //RULE 1
            discount = (decimal)0.10;
        else if (discount20 && !discount10) //RULE 2
            discount = (decimal)0.20;

        decimal totalPurchase = 0;
        decimal totalPurchaseItems = 0;
        decimal totalDiscount = 0;
        var listProductIds = request.Products.Select(x => x.ProductId).ToList();
        var total = await _productRepository.GetTotalById(listProductIds);

        var totalPaginas = total / 10;//10 - CONFIG PARAMETER
        if (totalPaginas == 0)
            totalPaginas = 1;

        for (int page = 1; page <= totalPaginas; page++)
        {
            var listProducts = await _productRepository.GetProductsByIdList(listProductIds, page, 10); //10 - CONFIG PARAMETER
            foreach (var product in listProducts)
            {
                var quantity = request.Products.Find(x => x.ProductId == product.Id).Quantity;
                totalPurchase += product.Price * quantity;
            }
        }

        totalPurchaseItems = totalPurchase;

        if (discount > 0)
        {
            totalDiscount = totalPurchase * discount;
            totalPurchase -= totalDiscount;
        }

        GetDiscountPurchaseResult response = new GetDiscountPurchaseResult();
        response.Canceled = false;
        response.Products = _mapper.Map<List<ProductQuantityResult>>(request.Products);
        response.TotalSale = totalPurchase;
        response.Discount = totalDiscount;
        response.TotalSaleItems = totalPurchaseItems;

        return response;
    }

    public static Task<bool> GetDiscount10(GetDiscountPurchaseCommand request)
    {
        bool exist = request.Products.Any(p => p.Quantity == 4); //CONFIG

        return Task.FromResult(exist);
    }

    public static Task<bool> GetDiscount20(GetDiscountPurchaseCommand request)
    {
        bool exist = request.Products.Any(p => p.Quantity >= 10 && p.Quantity <= 20); //CONFIG

        return Task.FromResult(exist);
    }
}

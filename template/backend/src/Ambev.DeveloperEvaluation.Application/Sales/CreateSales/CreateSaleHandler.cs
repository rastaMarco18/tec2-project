﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using Serilog;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly ISaleProductRepository _saleProductRepository;
    private readonly IMapper _mapper;

    public CreateSaleHandler(ISaleRepository saleRepository, ISaleProductRepository saleProductRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _saleProductRepository = saleProductRepository;
        _mapper = mapper;
    }

    public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
    {
        var validator = new CreateSaleCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var sale = _mapper.Map<Sale>(command);
        sale.CreatedAt = DateTime.UtcNow;
        var createdSale = await _saleRepository.CreateAsync(sale, cancellationToken);

        var request = new CompleteSaleCommand()
        {
            SaleId = createdSale.Id,
            Products = command.Products
        };

        await CompleteSale(request);

        var result = _mapper.Map<CreateSaleResult>(createdSale);
        return result;
    }

    public async Task CompleteSale(CompleteSaleCommand request)
    {
        try
        {
            foreach (var product in request.Products)
            {
                var saleProduct = new SaleProduct();
                saleProduct.Sale_Id = request.SaleId;
                saleProduct.Product_Id = product.ProductId;
                saleProduct.Quantity = product.Quantity;
                await _saleProductRepository.CreateAsync(saleProduct);
            }
        }
        catch (Exception ex)
        {
            Log.Error("An error has ocurred to finished -> FUNCTION COMPLETESALE()");
        }
    }
}

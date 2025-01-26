using Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSales;
using Ambev.DeveloperEvaluation.Application.Sales.GetSales;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Discounts.GetDiscount;
using Ambev.DeveloperEvaluation.WebApi.Features.Purchases.GetPurchaseDiscounts;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales;

/// <summary>
/// Controller for managing sale operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PurchasesController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of SalesController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public PurchasesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new user
    /// </summary>
    /// <param name="request">The user creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created user details</returns>
    [HttpPost("DiscountPurchase")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetPurchaseResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetDiscountPurchase([FromBody] GetDiscountRequest request, CancellationToken cancellationToken)
    {
        var validator = new GetPurchaseValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetDiscountPurchaseCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<GetPurchaseResponse>
        {
            Success = true,
            Message = "Discount response",
            Data = _mapper.Map<GetPurchaseResponse>(response)
        });
    }

}

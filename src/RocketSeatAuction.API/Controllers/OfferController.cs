using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.Communication.Requests;
using RocketSeatAuction.API.Filters;
using RocketSeatAuction.API.UseCases.Offers.CreateOffer;

namespace RocketSeatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketSeatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);
        return Created(string.Empty, id);

    }

}

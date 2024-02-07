using Microsoft.AspNetCore.Mvc;

namespace RocketSeatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
        return Ok("Okaay");
    }



}

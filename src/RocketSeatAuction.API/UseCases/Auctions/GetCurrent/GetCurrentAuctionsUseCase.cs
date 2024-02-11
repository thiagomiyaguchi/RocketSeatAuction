using RocketSeatAuction.API.Contracts;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionsUseCase
{
    private readonly IAuctionRepository _repository;
    public GetCurrentAuctionsUseCase(IAuctionRepository repository) => _repository = repository;



    public Auction? Execute()
    {
        return _repository.GetCurrent();

    }


}

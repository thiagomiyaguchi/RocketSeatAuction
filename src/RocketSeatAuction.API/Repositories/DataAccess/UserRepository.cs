using RocketSeatAuction.API.Contracts;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RocketSeatAuctionDbContext _dbContext;
    public UserRepository(RocketSeatAuctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}

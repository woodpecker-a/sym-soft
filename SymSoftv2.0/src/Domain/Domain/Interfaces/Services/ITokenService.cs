using System.Security.Claims;

namespace Domain.Interfaces.Services
{
    public interface ITokenService
    {
        Task<string> GetJwtToken(IList<Claim> claims);
    }
}
using System.Security.Claims;

namespace Interface.Services
{
    public interface ITokenService
    {
        Task<string> GetJwtToken(IList<Claim> claims);
    }
}
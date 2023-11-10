using DApplication.Models.DTOs;

namespace DApplication.Interfaces
{
    public interface ITokenService
    {
        string GetToken(UserDTO user);
    }
}

using MeetMasterApi.Dtos;
using MeetMasterApi.Models;

namespace MeetMasterApi.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(RegisterDto request);
        Task<TokenResponseDto?> LoginAsync(LoginDto request);
        Task<TokenResponseDto?> RefershTokensAsync(RefreshTokenRequestDto request);
    }
}

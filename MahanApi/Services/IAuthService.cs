using MahanApi.Dtos;
using MahanApi.Models;

namespace MahanApi.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(RegisterDto request);
        Task<TokenResponseDto?> LoginAsync(LoginDto request);
        Task<TokenResponseDto?> RefershTokensAsync(RefreshTokenRequestDto request);
    }
}

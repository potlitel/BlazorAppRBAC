using BlazorAppRBAC.Shared.DTOs;

namespace BlazorAppRBAC.Client.HttpRepository
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);

        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);

        Task Logout();
    }
}
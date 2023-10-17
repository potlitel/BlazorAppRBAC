using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorAppRBAC.Client.AuthProviders
{
    public class TestAuthStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymous = new ClaimsIdentity();
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        }
    }
}
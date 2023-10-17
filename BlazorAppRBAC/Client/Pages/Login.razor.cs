using BlazorAppRBAC.Client.HttpRepository;
using BlazorAppRBAC.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace BlazorAppRBAC.Client.Pages
{
    public partial class Login
    {
        private UserForAuthenticationDto _userForAuthentication = new();

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; } = null!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        public bool ShowAuthError { get; set; }
        public string Error { get; set; } = null!;

        public async Task ExecuteLogin()
        {
            ShowAuthError = false;

            var result = await AuthenticationService.Login(_userForAuthentication);
            if (!result.IsAuthSuccessful)
            {
                Error = result.ErrorMessage;
                ShowAuthError = true;
            }
            else
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
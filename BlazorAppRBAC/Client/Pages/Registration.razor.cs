using BlazorAppRBAC.Client.HttpRepository;
using BlazorAppRBAC.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace BlazorAppRBAC.Client.Pages
{
    public partial class Registration
    {
        private UserForRegistrationDto _userForRegistration = new UserForRegistrationDto();

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; } = null!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        public bool ShowRegistrationErros { get; set; }
        public IEnumerable<string> Errors { get; set; } = null!;

        public async Task Register()
        {
            ShowRegistrationErros = false;

            var result = await AuthenticationService.RegisterUser(_userForRegistration);
            if (!result.IsSuccessfulRegistration)
            {
                Errors = result.Errors;
                ShowRegistrationErros = true;
            }
            else
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
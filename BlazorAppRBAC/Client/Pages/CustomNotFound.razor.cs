using Microsoft.AspNetCore.Components;

namespace BlazorAppRBAC.Client.Pages
{
    public partial class CustomNotFound
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        public void NavigateToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
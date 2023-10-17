using BlazorAppRBAC.Client.HttpRepository;
using BlazorAppRBAC.Client.Shared;
using BlazorAppRBAC.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorAppRBAC.Client.Pages
{
    public partial class UpdateProduct
    {
        private Product _product;
        private SuccessNotification _notification;

        [Inject]
        private IProductHttpRepository ProductRepo { get; set; } = null!;

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _product = await ProductRepo.GetProduct(Id);
        }

        private async Task Update()
        {
            await ProductRepo.UpdateProduct(_product);
            _notification.Show();
        }

        private void AssignImageUrl(string imgUrl) => _product.ImageUrl = imgUrl;
    }
}
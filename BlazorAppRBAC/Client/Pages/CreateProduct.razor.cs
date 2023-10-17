using BlazorAppRBAC.Client.HttpRepository;
using BlazorAppRBAC.Client.Shared;
using BlazorAppRBAC.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorAppRBAC.Client.Pages
{
    public partial class CreateProduct
    {
        private Product _product = new Product();
        private SuccessNotification _notification = null!;

        [Inject]
        public IProductHttpRepository ProductRepo { get; set; }

        private async Task Create()
        {
            await ProductRepo.CreateProduct(_product);
            _notification.Show();
        }

        private void AssignImageUrl(string imgUrl) => _product.ImageUrl = imgUrl;
    }
}
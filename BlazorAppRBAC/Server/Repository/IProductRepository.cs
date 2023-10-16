using BlazorAppRBAC.Server.Paging;
using BlazorAppRBAC.Shared.Models;
using BlazorAppRBAC.Shared.RequestFeatures;

namespace BlazorAppRBAC.Server.Repository
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetProducts(ProductParameters productParameters);

        Task CreateProduct(Product product);

        Task<Product> GetProduct(Guid id);

        Task UpdateProduct(Product product, Product dbProduct);

        Task DeleteProduct(Product product);
    }
}
using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.Interfaces;

namespace IMS.UseCases.Products
{
    public class ViewProductByNameUseCase : IViewProductByNameUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductByNameUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
        {
            return await productRepository.GetProductsByNameAsync(name);
        }
    }
}
using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Activities
{
    public class ProduceProductUseCase : IProduceProductUseCase
    {
        private readonly IProductTransactionRepository productTransactionRepository;
        private readonly IProductRepository productRepository;

        public ProduceProductUseCase(IProductTransactionRepository productTransactionRepository, IProductRepository ProductRepository)
        {
            this.productTransactionRepository = productTransactionRepository;
            productRepository = ProductRepository;
        }

        public async Task ExecuteAsync(string productionNumber, Product product, int quantity, string doneBy)
        {
            await this.productTransactionRepository.ProduceAsync(productionNumber, product, quantity, doneBy);

            product.Quantity += quantity;
            await this.productRepository.UpdateProductAsync(product);
        }
    }
}
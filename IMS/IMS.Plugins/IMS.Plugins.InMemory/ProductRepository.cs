﻿using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() { ProductId = 1, ProductName = "Bike", Quantity = 10, Price = 150 },
                new Product() { ProductId = 2, ProductName = "Car", Quantity = 5, Price = 25000 },
            };
        }

        public async Task<IEnumerable<Product>> GetProductsbyAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return await Task.FromResult(_products);
            }

            return _products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

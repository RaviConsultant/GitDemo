using System.Collections.Generic;
using Requirement.Data.Models;
using Requirement.Data.Repositories;

namespace Requirement.Services.Products
{
    public class ProductService
    {
        private IEnumerable<Product> _products;
        private readonly ProductRepositories _productRepo = new ProductRepositories();

        public ProductService()
        {
            _productRepo = new ProductRepositories();
            _products = _productRepo.GetProduct();

        }
        public IEnumerable<Product> GetProduct()
        {
            return _products;
        }

        public Product GetProduct(int id)
        {
            Product product = _productRepo.GetProduct(id);
            return product;
        }
        public Product AddProduct(Product product)
        {
            Product pro = _productRepo.AddProduct(product);
            return pro;
        }
        public Product UpdateProduct(Product product)
        {
            Product pro = _productRepo.UpdateProduct(product);
            return pro;
        }
    }
}
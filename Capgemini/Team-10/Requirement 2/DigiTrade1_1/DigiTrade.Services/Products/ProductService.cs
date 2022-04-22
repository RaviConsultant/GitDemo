using System;
using DigiTrade.Data.Repositories;
using DigiTrade.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiTrade.Services.Products
{
    
    public class ProductService
    {

        private IEnumerable<Product> _products;
        private readonly ProductRepository _productRepo = new ProductRepository();
        public ProductService()
        {
            _productRepo = new ProductRepository();
            _products = _productRepo.GetProducts();

        }

        public IEnumerable<Product> GetProducts()
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
            Product pr = _productRepo.AddProduct(product);
            return pr;
        }
        public Product UpdateProduct(Product product)
        {
            Product pr = _productRepo.UpdateProduct(product);
            return pr;
        }
    }
}

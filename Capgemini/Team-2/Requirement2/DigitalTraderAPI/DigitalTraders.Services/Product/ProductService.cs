using DigitalTraders.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using DigitalTraders.Data.Models;
using System.Linq;
using System.Threading.Tasks;
namespace DigitalTraders.Services.Product
{
    public class ProductService
    {
        private IEnumerable<Products> _products;
        private readonly ProductRepository _productRepo = new ProductRepository();
        public ProductService()
        {
            _productRepo = new ProductRepository();
            _products = _productRepo.GetProduct();

        }
        public IEnumerable<Products> GetProducts()
        {
            return _products;
        }
        public Products GetProducts(int id)
        {
            Products products = _productRepo.GetProduct(id);
            return products;
        }
        public Products AddProduct(Products products)
        {
            Products pro = _productRepo.AddProduct(products);
            return pro;
        }
        public Products UpdateProduct(Products products)
        {
            Products pro = _productRepo.UpdateProduct(products);
            return pro;
        }
    }
}

using DigiTrade.Data.Repositories;
using DigiTrade.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiTrade.Services.Product
{
      public class ProductService
    {
        private IEnumerable<Products> _products;
        private readonly ProductRepository _productRepo = new ProductRepository();
        public ProductService()
        {
            _productRepo = new ProductRepository();
            _products = _productRepo.GetProducts();
        }
        public IEnumerable<Products> GetProducts()
        {
            return _products;
        }
        public Products GetProducts(int id)
        {
            Products product = _productRepo.GetProducts(id);
            return product;
        }
        public Products AddProduct(Products product)
        {
            Products prod = _productRepo.AddProduct(product);
            return prod;
        }
        public Products UpdateProduct(Products product)
        {
            Products prod = _productRepo.UpdateProduct(product);
            return prod;
        }
    }
}

using DigiTrade.DataLayer.Models;
using DigiTrade.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIgiTrade.ServiceLayer.ProductDetails
{
    public class ProductService
    {

        IEnumerable<Products> _products;

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
        public Products GetProduct(int id)
        {
            Products product = _productRepo.GetProduct(id);
            return product;
        }


        public Products AddProduct(Products product)
        {
            Products pro = _productRepo.AddProduct(product);
            return pro;
        }
        public Products UpdateProduct(Products product)
        {
            Products pro = _productRepo.UpdateProduct(product);
            return pro;
        }
    }
}


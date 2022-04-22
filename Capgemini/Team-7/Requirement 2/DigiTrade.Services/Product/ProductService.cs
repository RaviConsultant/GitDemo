using System;
using System.Collections.Generic;
using System.Text;
using DigiTrade.Data.Models;
using DigiTrade.Data.Repositories;
using System.Linq;
using System.Threading.Tasks;


namespace DigiTrade.Service.Product
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
        //public IEnumerable<Products> GetActiveProducts()
        //{
        //    var pros = _products.Where(e => e.IsActive == true);
        //    return pros;
        //}
        public Products GetProducts(int id)
        {
            var product = _productRepo.GetProducts(id);
            return product;
        }
        public Products AddProducts(Products product)
        {
            Products pro = _productRepo.AddProducts(product);
            return pro;
        }
        public Products UpdateProducts(Products product)
        {
            Products pro = _productRepo.UpdateProducts(product);
            return pro;
        }
    }
}

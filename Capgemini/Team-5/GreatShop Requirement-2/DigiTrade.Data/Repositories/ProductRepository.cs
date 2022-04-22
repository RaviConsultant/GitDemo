using DigiTrade.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiTrade.Data.Repositories
{
    public class ProductRepository
    {
        private DigiTradeShoppingContext _DbApi;

        private IEnumerable<Products> _products;
        public ProductRepository()
        {
            _DbApi = new DigiTradeShoppingContext();
            _products = _DbApi.Products;
        }
        public IEnumerable<Products> GetProducts()
        {
            var products = from product in _DbApi.Products.Include(product => product.Brand)
                           select new Products
                           {
                               ProdId = product.ProdId,
                               ProdName = product.ProdName,
                               Processor = product.Processor,
                               Ram = product.Ram,
                               Rom = product.Rom,
                               PrimaryCam = product.PrimaryCam,
                               FrontCam = product.FrontCam,
                               Battery = product.Battery,
                               Tax = product.Tax,
                               SalesPrice = product.SalesPrice - ((int)product.SalesPrice / 10),
                               BrandId = product.BrandId,
                               Brand = product.Brand,



                           };
            return (IEnumerable<Products>)products;
        }
        public Products GetProducts(int id)
        {
            Products product = _products.FirstOrDefault(product => product.ProdId == id);
            return product;
        }
        public Products AddProduct(Products product)
        {
            _DbApi.Products.Add(product);
            _DbApi.SaveChangesAsync();
            return product;
        }
        public Products UpdateProduct(Products product)
        {
            _DbApi.Update(product);
            _DbApi.SaveChangesAsync();
            return product;
        }
    }
}

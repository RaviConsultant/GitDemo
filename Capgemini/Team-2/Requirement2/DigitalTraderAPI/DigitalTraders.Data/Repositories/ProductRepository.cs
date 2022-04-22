using DigitalTraders.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalTraders.Data.Repositories
{
    public class ProductRepository
    {
        private DigitalTradersContext _dbdigitalTraders;
        private IEnumerable<Products> _product;
        public ProductRepository()
        {
            _dbdigitalTraders = new DigitalTradersContext();
            _product = _dbdigitalTraders.Products;
        }
        public IEnumerable<Products> GetProduct()
        {
            var products = from product in _dbdigitalTraders.Products.Include(product => product.Brand)
                           select new Products
                           {
                               Id = product.Id,
                               ProductTitle=product.ProductTitle,
                               ProductDescription=product.ProductDescription,
                               SalePrice = (decimal)(0.9) * (product.SalePrice),
                               CurrentStock = product.CurrentStock,
                               BrandId = product.BrandId,
                               //Brand=product.Brand,
                               Processor=product.Processor,
                               Ram=product.Ram,
                               Rom=product.Rom,
                               PrimaryCamera=product.PrimaryCamera,
                               FrontCamera=product.FrontCamera,
                               Battery=product.Battery,
                           };
            return (IEnumerable<Products>)products;
        }

        public Products GetProduct(int id)
        {
            Products product = _product.FirstOrDefault(pro => pro.Id == id);
            return product;
        }
        public Products AddProduct(Products product)
        {
            _dbdigitalTraders.Products.Add(product);
            _dbdigitalTraders.SaveChangesAsync();
            return product;
        }
        public Products UpdateProduct(Products product)
        {
            _dbdigitalTraders.Update(product);
            _dbdigitalTraders.SaveChangesAsync();
            return product;
        }

    }
}

using System;
using System.Collections.Generic;
using DigiTrade.Data.Models;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DigiTrade.Data.Repositories
{
    public class ProductRepository
    {
        private DigiTradeContext _dbDigiTrade;
        private IEnumerable<Products> _products;
       
        public ProductRepository()
        {
            _dbDigiTrade = new DigiTradeContext();
            _products = _dbDigiTrade.Products;
        }
        public IEnumerable<Products> GetProducts()
        {
            var products = from product in _dbDigiTrade.Products.Include(product => product.Brand)
                           select new Products
                           {
                               Id = product.Id,
                               ProductTitle=product.ProductTitle,
                               ProductDescription=product.ProductDescription,
                               SalePrice = (decimal)(0.9)*(product.SalePrice),
                               CurrentStock=product.CurrentStock,
                               BrandId=product.BrandId,
                               //Brand=product.Brand,
                               Processor=product.Processor,
                               Ram=product.Ram,
                               Rom=product.Rom,
                               PrimaryCamera=product.PrimaryCamera, 
                               FrontCamera=product.FrontCamera, 
                               Battery=product.Battery
                           };
                                             
            return (IEnumerable<Products>)products;
        }

    //public IEnumerable<Products> GetActiveProducts()
    //{
    //    var employees = _products.Where(e => e.IsActive == true);
    //    return employees;
    //}
        public Products GetProducts(int id)
        {
            //Products product = _products.FirstOrDefault(emp => emp.Id == id);
            //return product;
            var products = from product in _dbDigiTrade.Products.Include(product => product.Brand)
                           where product.Id == id
                           select new Products
                           {
                               Id = product.Id,
                               ProductTitle = product.ProductTitle,
                               ProductDescription = product.ProductDescription,
                               SalePrice = (decimal)(0.9) * (product.SalePrice),
                               CurrentStock = product.CurrentStock,
                               BrandId = product.BrandId,
                               //Brand = product.Brand,
                               Processor = product.Processor,
                               Ram = product.Ram,
                               Rom = product.Rom,
                               PrimaryCamera = product.PrimaryCamera,
                               FrontCamera = product.FrontCamera,
                               Battery = product.Battery
                           };

            return products.First();
        }
        public Products AddProducts(Products product)
        {
            _dbDigiTrade.Products.Add(product);
            _dbDigiTrade.SaveChangesAsync();
            return product;
        }
        public Products UpdateProducts(Products product)
        {
            _dbDigiTrade.Update(product);
            _dbDigiTrade.SaveChangesAsync();
            return product;
        }


    }
}

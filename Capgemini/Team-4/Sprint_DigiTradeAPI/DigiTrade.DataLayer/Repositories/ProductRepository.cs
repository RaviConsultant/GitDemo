using DigiTrade.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiTrade.DataLayer.Repositories
{
    public class ProductRepository
    {
        private DigitalTradeDbContext _dbDigiTradeContext;
        private IEnumerable<Products> _products;
        
        public ProductRepository()
        {
            _dbDigiTradeContext = new DigitalTradeDbContext();
            _products = _dbDigiTradeContext.Products;
        }

        public IEnumerable<Products> GetProducts()
        {
            var products = from product in _dbDigiTradeContext.Products.Include(product => product.Brand)
                           select new Products
                           {
                               ProductId = product.ProductId,
                               Title = product.Title,
                               Brand = product.Brand,
                               BrandId = product.BrandId,   
                               CurrentStock = product.CurrentStock,
                               PrimaryCamera=product.PrimaryCamera,
                               FrontCamera=product.FrontCamera,
                               Tax=product.Tax,
                               Ram=product.Ram,
                               Rom=product.Rom,
                               Processor=product.Processor,
                               Battery=product.Battery,
                               SalePrice = product.SalePrice - ((long)product.SalePrice / 10),
                               //SalePrice = (double)(0.9) * (product.SalePrice)



                               //Id = product.Id,
                               //ProductTitle = product.ProductTitle,
                               //Description = product.Description,
                               //SalePrice = product.SalePrice - ((long)product.SalePrice / 10),
                               //BrandId = product.BrandId,
                               //Brand = product.Brand,
                               //Processor = product.Processor,
                               //Ram = product.Ram,
                               //Rom = product.Rom,
                               //PrimaryCamera = product.PrimaryCamera,
                               //FrontCamera = product.FrontCamera,
                               //Battery = product.Battery
                           };



            return (IEnumerable < Products > )products;
        }


        public Products GetProduct(int id)
        {
            //Products product=new Products();
            // try
            //{
            //    if(id<500)
            //    {
            //        

            //        //return product;
            //    }
            //}
            // catch(Exception ex)
            //{
            //   Console.WriteLine(ex.Message);
            //}
           Products product = _products.FirstOrDefault(pro => pro.ProductId == id);

            return product;
           

           
           
        }
        public Products AddProduct(Products product)
        {
            _dbDigiTradeContext.Products.Add(product);
            _dbDigiTradeContext.SaveChangesAsync();
            return product;
        }
        public Products UpdateProduct(Products product)
        {
            _dbDigiTradeContext.Update(product);
            _dbDigiTradeContext.SaveChangesAsync();
            return product;
        }
    }
}


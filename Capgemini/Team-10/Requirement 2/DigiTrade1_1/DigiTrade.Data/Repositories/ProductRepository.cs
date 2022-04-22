using DigiTrade.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace DigiTrade.Data.Repositories
{
    public class ProductRepository
    {

        private DBContext _dbDigi;

        private IEnumerable<Product> _products;
        public ProductRepository()
        {   
            _dbDigi = new DBContext();
            
            var Db = from product in _dbDigi.Products.Include(product => product.Brand)
                     select new Product
                     {
                         Id = product.Id,
                         Title = product.Title,
                         Tax = product.Tax,
                         Description = product.Description,
                         Brand = product.Brand,
                         FrontCam = product.FrontCam,
                         CurStock = product.CurStock,
                         Battery = product.Battery,
                         BrandId = product.BrandId,
                         Ram = product.Ram,
                         Rom = product.Rom,
                         PrimaryCam = product.PrimaryCam,
                         Processor = product.Processor,
                         SalePrice = (long)((decimal)(0.9) * (product.SalePrice))
                     };

            _products = Db;
        }
        public IEnumerable<Product> GetProducts()
        {
          
            return _products;
        }

        public Product GetProduct(int id)
        {
            Product product = _products.Where(pr => pr.Id == id).FirstOrDefault();
                  if (product == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No product with ID = {0}", id)),
                    ReasonPhrase = "Product ID Not Found"
                }; 
                throw new HttpResponseException(resp);
                    
            }
            return product;

            
        }
        public Product AddProduct(Product product)
        {
            _dbDigi.Products.Add(product);
            _dbDigi.SaveChangesAsync();
            return product;
        }
        public Product UpdateProduct(Product product)
        {
            _dbDigi.Update(product);
            _dbDigi.SaveChangesAsync();
            return product;
        }
    }
}

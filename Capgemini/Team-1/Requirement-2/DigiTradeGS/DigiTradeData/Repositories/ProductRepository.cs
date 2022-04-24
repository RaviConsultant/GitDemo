using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiTradeData.Models;
using Microsoft.EntityFrameworkCore;

namespace DigiTradeData.Repositories
{
    public class ProductRepository
    {
        private ProductContext _dbDigiTrade;

        private IEnumerable<Product> _Products;
        public ProductRepository()
        {
            _dbDigiTrade = new ProductContext();
            _Products = _dbDigiTrade.Products;
        }
        public IEnumerable<Product> GetProduct()
        {
            var products = from product in _dbDigiTrade.Products.Include(product => product.Brand)
                           select new Product
                           {
                               Id = product.Id,
                               ProductTitle = product.ProductTitle,
                               Description = product.Description,
                               SalePrice = product.SalePrice - ((long)product.SalePrice / 10),
                               BrandId = product.BrandId,
                               Cur_Stock = product.Cur_Stock,
                               Tax=product.Tax,
                               Brand=product.Brand,
                               Processor=product.Processor,
                               Ram=product.Ram,
                               Rom=product.Rom, 
                               PrimaryCamera=product.PrimaryCamera,
                               FrontCamera=product.FrontCamera,
                               Battery=product.Battery

                           };
            return (IEnumerable<Product>)products;
        }
        //public IEnumerable<Product> GetActiveProduct()
        //{
        //    var products = _Products.Where(e => e.IsActive == true);
        //    return products;
        //}
        public Product GetProduct(int id)
        {
            Product product = _Products.FirstOrDefault(pro => pro.Id == id);
            return product;
        }
        public Product AddProduct(Product product)
        {
            _dbDigiTrade.Products.Add(product);
            _dbDigiTrade.SaveChangesAsync();
            return product;
        }
        public Product UpdateProduct(Product product)
        {
            _dbDigiTrade.Update(product);
            _dbDigiTrade.SaveChangesAsync();
            return product;
        }

    }
}

using System;
using System.Collections.Generic;
//using DigiTrade.Data.Models;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capgemini_Data.Models;


// all _Products into _product
namespace DigiTrade.Data.Repositories
{
    public class ProductRepository
    {
        private ProductContext _dbDigiTrade;
        private IEnumerable<Product> _product;
        public ProductRepository()
        {
            _dbDigiTrade = new ProductContext();
            _product = _dbDigiTrade.Products;
        }
        public IEnumerable<Product> GetProduct()
        {
              return _product;
           // // public IEnumerable<Product> GetProduct()
           ////  {
            //var products = from product in _dbDigiTrade.Products.Include(product => product.Brand)
            //               select new Product
            //               {
            //                   Id = product.Id,
            //                   ProductTitle = product.ProductTitle,
            //                   Discription = product.Discription,
            //                   SalePrice = product.SalePrice - ((long)product.SalePrice / 10),
            //                   BrandId = product.BrandId,
            //                   Brand = product.Brand,
            //                   Processor = product.Processor,
            //                   Ram = product.Ram,
            //                   Rom = product.Rom,
            //                   PrimaryCam = product.PrimaryCam,
            //                   FrontCam = product.FrontCam,
            //                   Battery = product.Battery

            //               };
            //return (IEnumerable<Product>)products;
       // }
    }

    //public IEnumerable<Products> GetActiveProducts()
    //{
    //    var employees = _products.Where(e => e.IsActive == true);
    //    return employees;
    //}
    public Product GetProduct(int id)
    {
        Product product = _product.FirstOrDefault(emp => emp.Id == id);
        return product;
    }
    public Product AddProducts(Product product)
    {
        //  object p = _dbDigiTrade.Products.Add(product);
        _dbDigiTrade.SaveChangesAsync();
        return product;
    }
    public Product UpdateProducts(Product product)
    {
        _dbDigiTrade.Update(product);
        _dbDigiTrade.SaveChangesAsync();
        return product;
    }


}
}

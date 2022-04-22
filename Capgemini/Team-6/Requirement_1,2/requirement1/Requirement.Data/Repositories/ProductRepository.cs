using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requirement.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace Requirement.Data.Repositories
{
    public class ProductRepositories
    {
        private EverythingContext _dbEverything;

        private IEnumerable<Product> _Products;
        public ProductRepositories()
        {
            _dbEverything = new EverythingContext();
            _Products = _dbEverything.Products;
        }
       public IEnumerable<Product> GetProduct()
        {
            var products = from product in _dbEverything.Products
                           select new Product
                           {
                               Id = product.Id,
                               Title=product.Title,
                               Description=product.Description,
                               SalePrice= product.SalePrice-((long)product.SalePrice / 10),
                               BrandName=product.BrandName,
                               Processor=product.Processor,
                               Ram=product.Ram,
                               Rom=product.Rom, 
                               PrimaryCam=product.PrimaryCam,
                               MainCam=product.MainCam,
                               Battery=product.Battery,
                               Tax=product.Tax,
                               CurStock=product.CurStock

                           };
            return (IEnumerable<Product>)products;
        }
       
        public Product GetProduct(int id)
        {
            Product product = _Products.FirstOrDefault(pro => pro.Id == id);
            return product;
        }
        public Product AddProduct(Product product)
        {
            _dbEverything.Products.Add(product);
            _dbEverything.SaveChangesAsync();
            return product;
        }
        public Product UpdateProduct(Product product)
        {
            _dbEverything.Update(product);
            _dbEverything.SaveChangesAsync();
            return product;
        }

    }
}

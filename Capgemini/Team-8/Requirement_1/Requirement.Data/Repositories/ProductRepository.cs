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
            private NewContext _dbNew;

            private IEnumerable<Product> _Products;
            public ProductRepositories()
            {
                _dbNew = new NewContext();
                _Products = _dbNew.Products;
            }
            public IEnumerable<Product> GetProduct()
            {
                return _Products;
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
                _dbNew.Products.Add(product);
                _dbNew.SaveChangesAsync();
                return product;
            }
            public Product UpdateProduct(Product product)
            {
                _dbNew.Update(product);
                _dbNew.SaveChangesAsync();
                return product;
            }

        }
    }


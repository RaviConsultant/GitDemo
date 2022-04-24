using System;
using System.Collections.Generic;
using System.Text;
//using DigiTrade.Data.Models;
using DigiTrade.Data.Repositories;
using System.Linq;
using System.Threading.Tasks;
using Capgemini_Data.Models;

namespace DigiTrade.Service
{
    public class ProductService
    {
        private IEnumerable<Product> _products;
        private readonly ProductRepository _productRepo = new ProductRepository();

        public ProductService()
        {
            _productRepo = new ProductRepository();
            _products = _productRepo.GetProduct();
        }
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
        //public IEnumerable<Products> GetActiveProducts()
        //{
        //    var pros = _products.Where(e => e.IsActive == true);
        //    return pros;
        //}
        public Product GetProduct(int id)
        {
            Product product = _productRepo.GetProduct(id);
            return product;
        }

        public void AddProducts(Product pro)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product pro)
        {
            throw new NotImplementedException();
        }

        //public Product AddProduct(Product product)
        //{
        //    Product pro = _productRepo.AddProduct(product);
        //    return pro;
        //    ////throw new NotImplementedException();
        //}

        //public Product UpdateProduct(Product product)
        //{
        //    Product pro = _productRepo.UpdateProducts(product);
        //    return pro;
        //    //throw new NotImplementedException();
        //}
        //public Capgemini_Data.Models.Product AddProduct(Capgemini_Data.Models.Product product)
        //{
        //    Capgemini_Data.Models.Product pro = _productRepo.AddProducts(product);
        //    return pro;
        //}
        //public Capgemini_Data.Models.Product UpdateProducts(Capgemini_Data.Models.Product product)
        //{
        //    Capgemini_Data.Models.Product pro = _productRepo.UpdateProducts(product);
        //    return pro;
        //}
    }
}

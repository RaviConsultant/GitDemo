using DigiTrade.Data.Models;
using DigiTrade.Services.Products;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DigiTrade.Data.Repositories;
namespace DigiTrader.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   
    public class ProductController : ControllerBase
    {
       
        private ProductService prService = new ProductService();
        [HttpGet]
        // https://localhost:44351/api/Product
        public IEnumerable<Product> Index()
        {

            return prService.GetProducts();
        }
        [HttpGet("{id}")]
        // https://localhost:44351/api/Product/2

        public ActionResult<Product> Index(int id)
        {
        
            return prService.GetProduct(id);
        }


       // [HttpPost]
        // https://localhost:44351/api/Product
        // pass product object in request body
        //public async Task<ActionResult<Product>> PostProduct(Product pr)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        throw new System.Exception("Invalid Product");
        //    }
        //    else
        //    {
        //        prService.AddProduct(pr);
        //        return pr;
        //    }
        //}
        //[HttpPut("{id}")]
        //public async Task<ActionResult<Product>> PutProduct(short id, Product pr)
        //{
        //    if (id != pr.Id)
        //    {
        //        return NotFound();
        //    }
        //    if (!ModelState.IsValid)
        //    {
        //        throw new System.Exception("Invalid Product");
        //    }
        //    else
        //    {
        //        prService.UpdateProduct(pr);
        //        return pr;
        //    }

        //}
    }
}

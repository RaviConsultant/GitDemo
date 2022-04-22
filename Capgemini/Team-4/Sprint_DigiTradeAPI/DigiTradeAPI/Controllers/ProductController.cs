using DigiTrade.DataLayer.Models;
using DIgiTrade.ServiceLayer.ProductDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiTradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private ProductService proService = new ProductService();
        [HttpGet]
        // https://localhost:44348/api/Product
        public IEnumerable<Products> Index() 
        {
            
            return proService.GetProducts();
        }
        [HttpGet("{id}")]
        // https://localhost:44348/api/Product/1
        public ActionResult<Products> Index(int id)
        {



            return proService.GetProduct(id);




        }


        [HttpPost]
        // https://localhost:44348/api/Product
        // pass product object in request body
        public async Task<ActionResult<Products>> PostProduct(Products pro)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Invalid Product");
            }
            else
            {
                proService.AddProduct(pro);
                return pro;
            }
        }
        [HttpPut("{id}")]


        // pass product object in request body
        public async Task<ActionResult<Products>> PutProduct(short id, Products pro)
        {
            if (id != pro.ProductId)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Invalid Product");
            }
            else
            {
                proService.UpdateProduct(pro);
                return pro;
            }
        }
    }
}

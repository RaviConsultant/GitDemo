using DigiTrade.Data.Models;
using DigiTrade.Services.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalTradeAPI.Controllers
{
    [Route("[controller]")]
    [Controller]
    public class ProductController : ControllerBase
    {
        private ProductService prodService = new ProductService();

        [HttpGet]
        public IEnumerable<Products> Index()
        {
            return prodService.GetProducts();
        }

        [HttpGet("{id}")]
        public ActionResult<Products> Index(int id)
        {
            return prodService.GetProducts(id);
        }

        [HttpPost]
        // pass employee object in request body
        public async Task<ActionResult<Products>> PostProduct(Products prod)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Invalid Product");
            }
            else
            {
                prodService.AddProduct(prod);
                return prod;
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Products>> PutProduct(short id, Products prod)
        {
            if (id != prod.ProdId)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Invalid Employee");
            }
            else
            {
                prodService.UpdateProduct(prod);
                return prod;
            }
        }
    }
}

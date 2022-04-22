using DigitalTraders.Data.Models;
using DigitalTraders.Services.Product;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalTraderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductService proService = new ProductService();

        public IEnumerable<Products> Index()
        {
            return proService.GetProducts();
        }
        [HttpGet("{id}")]

        public ActionResult<Products> Index(int id)
        {
            return proService.GetProducts(id);
        }

        [HttpPost]
        public async Task<ActionResult<Products>> PostProducts(Products pro)
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
        public async Task<ActionResult<Products>> PutProducts(short id, Products pro)
        {
            if (id != pro.Id)
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

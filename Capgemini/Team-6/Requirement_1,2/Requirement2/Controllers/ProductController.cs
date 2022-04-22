using Microsoft.AspNetCore.Mvc;
using Requirement.Data.Models;
using Requirement.Services.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Requirement2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private ProductService prodService = new ProductService();
        [HttpGet]
        public IEnumerable<Product> Index()
        {
            return prodService.GetProduct();
        }
        [HttpGet("{id}")]
        public ActionResult<Product> Index(int id)
        {
            return prodService.GetProduct(id);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product prod)
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
        public async Task<ActionResult<Product>> PutProduct(short id, Product prod)
        {
            if (id != prod.Id)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Invalid Product");
            }
            else
            {
                prodService.UpdateProduct(prod);
                return prod;
            }
        }

    }
}

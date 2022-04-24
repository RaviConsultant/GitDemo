using Capgemini_Data.Models;
//using DigiTrade.Data.Models;
//using DigiTrade.Service.Product;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Capgemini_Services.Product;
using DigiTrade.Service;

namespace DigitalTraderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductService proService = new ProductService();
       // [HttpGet]
        public IEnumerable<Product> Index()
        {
            return proService.GetProducts();
        }
        [HttpGet("{id}")]

        public ActionResult<Product> Index(int id)
        {
            return proService.GetProduct(id);
        }




        /// <summary>
        ///// /////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        public async Task<ActionResult<Product>> PostProducts(Product pro)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Exception("Invalid Product");
            }
            else
            {
                proService.AddProducts(pro);
                return pro;
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> PutProducts(short id, Product pro)
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
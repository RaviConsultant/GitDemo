using DigiTrade.Data.Models;
using DigiTrade.Service.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                var _product = proService.GetProducts();
                return proService.GetProducts();
            }
            catch(Exception e)
            {
                return Enumerable.Empty<Products>();
            }
            
        }
       
        

      [HttpGet("{id}")]

        public ActionResult<Products> Index(int id)
        {
            try
            {
                return proService.GetProducts(id);

            }
            catch (Exception e)
            {
                return new Products();
            }
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
                proService.AddProducts(pro);
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
                proService.UpdateProducts(pro);
                return pro;
            }
        }
    }
}
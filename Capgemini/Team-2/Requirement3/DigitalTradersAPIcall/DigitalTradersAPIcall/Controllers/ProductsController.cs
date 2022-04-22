using DigitalTradersAPIcall.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DigitalTradersAPIcall.Controllers
{
    public class ProductsController : Controller
    {
        //private readonly ILogger<ProductsController> _logger;
        string baseurl = "https://localhost:44380/";
        //public ProductsController(ILogger<ProductsController> logger)
        //{
        //    _logger = logger;
        //}
        public async Task<ActionResult> Index()
        {
            //calling web Api
            //and getting the data in view using DataTable
            DataTable dt = new DataTable();
            
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var client = new HttpClient(clientHandler))
            {
                client.BaseAddress = new System.Uri(baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage getData = await client.GetAsync("api/Products");
                
                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    dt = JsonConvert.DeserializeObject<DataTable>(results);
                   
                }
                else
                {
                    Console.WriteLine("Error while calling API!");
                }
                ViewData.Model = dt;
            }
            return View();
        }
        // GET: ProductsController/Details
        public ActionResult Details(int id)
        {
            //var entities = new Products();
            //var detailsModel = entities.Details.Single(e => e.Id == requestid);
            //return View(detailsModel);
            //return View(entities.Details.ToList())
            return View();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DigiTrade.Demo.Models;


namespace DigiTrade.Demo.Controllers
{
    public class ProductsController : Controller
    {
        string baseURL = "https://localhost:44397/";
        // GET: ProductsController
        public async Task<ActionResult> Index()
        {
            //Calling the web API and populating the data in the view  using datatable
            DataTable dt = new DataTable();
           
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using ( var client = new HttpClient(clientHandler))
             {
                client.BaseAddress = new System.Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                

                HttpResponseMessage getData = await client.GetAsync("api/Products");

                if(getData.IsSuccessStatusCode)
                {
                    string results =getData.Content.ReadAsStringAsync().Result;
                    dt = JsonConvert.DeserializeObject<DataTable>(results);
                }
                else
                {
                    Console.WriteLine("Error calling web API");
                }
                ViewData.Model = dt;

            }
            return View();
        }

        // GET: ProductsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Product product = new Product();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var client = new HttpClient(clientHandler))
            {
                client.BaseAddress = new System.Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage getData = await client.GetAsync("api/Products/"+id);
                
                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    product = JsonConvert.DeserializeObject<Product>(results);
                    
                }
                else
                {
                    Console.WriteLine("Error calling web API");
                }

                ViewData["ProductTitle"] =product.ProductTitle;
                ViewData["ProductDescription"] = product.ProductDescription;
                ViewData["SalePrice"] = product.SalePrice;
                ViewData["CurrentStock"] = product.CurrentStock;
                ViewData["BrandId"] = product.BrandId;
                ViewData["Processor"] = product.Processor;
                ViewData["ROM"] = product.ROM;
                ViewData["RAM"] = product.RAM;
                ViewData["PrimaryCamera"] = product.PrimaryCamera;
                ViewData["FrontCamera"] = product.FrontCamera;
                ViewData["Battery"] = product.Battery;
            }
            return View();
        }

     
       
        
    }
}

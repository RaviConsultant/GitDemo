using DigiTrade.Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DigiTrade.Demo.Controllers
{
    public class ProductsController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();
        Product product = new Product();
        List<Product> products = new List<Product>();
        string baseURL = "https://localhost:44383/";
        public ProductsController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }
        public async Task<IActionResult> IndexAsync()
        {
            List<Product> dt = new List<Product>();

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var client = new HttpClient(clientHandler))
            {
                client.BaseAddress = new System.Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage getData = await client.GetAsync("api/Product");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;

                    dt = JsonConvert.DeserializeObject <List<Product>>(results);
                }
                else
                {
                    Console.WriteLine("Error calling web API");
                }
                ViewData.Model = dt;

            }
        
            return View();
        }
        //[HttpGet]
        //public async Task<List<Product>> GetProducts()
        //{
        //    products = new List<Product>();
        //    using (var httpClient = new HttpClient())
        //    { using (var response = await httpClient.GetAsync("https://localhost:44383/api/Product"))
        //        { string apiResponse = await response.Content.ReadAsStringAsync();
        //            products = JsonConvert.DeserializeObject<List<Product>> (apiResponse);
        //        }
        //    }
        //    return products;
        //}
        //[HttpGet("{id}")]
        //public async Task<Product> GetProduct(int id)
        //{
        //    product = new Product();
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync("https://localhost:44383/api/Product/" + id))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            product = JsonConvert.DeserializeObject<Product>(apiResponse);
        //        }
        //    }

        //    return product;
        //}
        //public async Task<IActionResult> Details(int id)
        //{

        //    product = new Product();
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync(baseURL+"api/Product/" + id))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            product = JsonConvert.DeserializeObject<Product>(apiResponse);
        //        }
        //    }
        //    return View(product);
        //}
        public async Task<IActionResult> Details(int id)
        { Product dt= new Product();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var client = new HttpClient(clientHandler))
            {
                client.BaseAddress = new System.Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage getData = await client.GetAsync("api/Product/"+id);

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;

                    dt = JsonConvert.DeserializeObject<Product>(results);
                }
                else
                {
                    Console.WriteLine("Error calling web API");
                }
                ViewData.Model = dt;

            }
            return View();
        }

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<Product> UpdateProduct(Product product1)
        //{
        //    product = new Product();
        //    using (var httpClient = new HttpClient())
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(product1), Encoding.UTF8, "application/json"); 
        //        using (var response = await httpClient.GetAsync("https://localhost:44383/api/product", content))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            product = JsonConvert.DeserializeObject<Product>(apiResponse);
        //        }
        //    }
        //    return product;
        //}
    }
}

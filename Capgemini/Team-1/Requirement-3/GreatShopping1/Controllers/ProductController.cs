using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using GreatShopping1.Models;

namespace GreatShopping1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<Product> Product = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44379/");
                var responseTask = client.GetAsync("Product");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob =result.Content.ReadAsAsync<IList<Product>>();
                    readJob.Wait();
                    Product = readJob.Result;
                }
                else
                {
                    Product = Enumerable.Empty<Product>();
                    ModelState.AddModelError(string.Empty, "Server Error occured!");
                }
            }
            return View(Product);
        }

        public ActionResult ProductDetails(int id)
        {
            Product data = new Product();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44379/Product");
                var consume = client.GetAsync("Product/" + id.ToString());
                consume.Wait();
                var test = consume.Result;
                if (test.IsSuccessStatusCode)
                {
                    var display = test.Content.ReadAsAsync<Product>();
                    //display.Wait();
                    data = display.Result;
                }

                
            }
            catch (AggregateException err)
            {
                foreach (var errInner in err.InnerExceptions)
                {
                    Debug.WriteLine(errInner); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
                }
            }
            return View(data);


        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using DigiTradeshopping1.Models;

namespace DigiTradeshopping1.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Index()

        {
            List<Products> Product = new List<Products>();

            //IEnumerable<ProductModel> Product = Product1;

            //IEnumerable<ProductModel> Product = null;
            try
            {


                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44355/api/");
                    var responseTask = client.GetAsync("Product");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readJob = result.Content.ReadAsAsync<IList<Products>>();
                        readJob.Wait();
                        //Product = (IEnumerable<ProductModel>)readJob.Result;
                        Product.AddRange(readJob.Result);
                    }
                    else
                    {
                        Product.DefaultIfEmpty<Products>();
                        //Product = Enumerable.Empty<ProductModel>();
                        ModelState.AddModelError(string.Empty, "Server Error occured!");
                    }
                }
            }
            catch (AggregateException err)
            {
                foreach (var errInner in err.InnerExceptions)
                {
                    Debug.WriteLine(errInner); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
                }
            }
            return View(Product);
        }



        public ActionResult ProductDetails(int id)
        {
            Products data = new Products();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44355/");
                var consume = client.GetAsync("api/Product/" + id.ToString());
                consume.Wait();
                var test = consume.Result;
                if (test.IsSuccessStatusCode)
                {
                    var display = test.Content.ReadAsAsync<Products>();
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
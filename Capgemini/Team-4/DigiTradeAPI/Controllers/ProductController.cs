using DigiTradeAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DigiTradeAPI.Controllers
{
    public class ProductController : Controller
    {

        string baseURL = "https://localhost:44348/";


        // GET: Product
        //public async Task<ActionResult> Index()
        //{
        //    //calling WebApi and displaying on view using Datatable
        //    List<ProductModel> productModels = new List<ProductModel>();
        //   // ItrackDD itrackDD = new ItrackDD();
        //    DataTable dt = new DataTable();
        //    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;


        //    HttpClientHandler clientHandler = new HttpClientHandler();
        //  clientHandler.ServerCertificateCustomValidationCallback = (sender, cart, chain, sslPolicyError) => true;

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseURL);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        //        //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        //        //        System.Net.ServicePointManager.Expect100Continue = false;
        //              HttpResponseMessage getData = await client.GetAsync("Product");


        //        if (getData.IsSuccessStatusCode)
        //        {
        //            string results = getData.Content.ReadAsStringAsync().Result;

        //            dt = JsonConvert.DeserializeObject<DataTable>(results);

        //        }
        //        else
        //        {
        //            Console.WriteLine("Error in calling Web API");
        //        }

        //    }


        //        return View(dt);
        //}




        public ActionResult Index()
        
            {
            List<ProductModel> Product = new List<ProductModel>();

            //IEnumerable<ProductModel> Product = Product1;
           
            //IEnumerable<ProductModel> Product = null;
            try
            {


                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/api/");
                    var responseTask = client.GetAsync("Product");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readJob = result.Content.ReadAsAsync<IList<ProductModel>>();
                        readJob.Wait();
                       //Product = (IEnumerable<ProductModel>)readJob.Result;
                       Product.AddRange(readJob.Result);
                    }
                    else
                    {
                        Product.DefaultIfEmpty<ProductModel>();
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
            ProductModel data = new ProductModel();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44348/");
                var consume = client.GetAsync("api/Product/" + id.ToString());
                consume.Wait();
                var test = consume.Result;
                if (test.IsSuccessStatusCode)
                {
                    var display = test.Content.ReadAsAsync<ProductModel>();
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
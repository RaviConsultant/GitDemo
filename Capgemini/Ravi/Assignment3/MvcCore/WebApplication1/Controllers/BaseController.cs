using Microsoft.AspNetCore.Mvc;
using System;

namespace CodeFirst.Controllers
{
    //[MyHandleError(ExceptionType = typeof(Exception), View = "Error")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    //public class MyHandleError : HandleErrorAttribute
    //{
    //    public override void OnException(ExceptionContext filterContext)
    //    {
    //        base.OnException(filterContext);

    //        // log error to log file

    //        // send email to stack-holders

    //    }
    //}

}

using Microsoft.AspNetCore.Mvc;

namespace CustomerAssignment.Controllers
{
    public class CustomerControllerEmpty : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

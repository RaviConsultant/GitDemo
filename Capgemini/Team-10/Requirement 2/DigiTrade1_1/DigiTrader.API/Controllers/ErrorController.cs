using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;

using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace DigiTrader.API.Controllers
{

    [ApiController]
    public class ErrorsController : ControllerBase
    {

        [Route("/error")]
        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var statusCode = exception.Error.GetType().Name switch
            {
                "ArgumentException" => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.ServiceUnavailable
            };

            return Problem(detail: exception.Error.Message, statusCode: (int)statusCode);
        }
        [Route("/Error/404")]
        public IActionResult Error2()
        {
            

            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();
          
            return Problem();
        }

    }
}

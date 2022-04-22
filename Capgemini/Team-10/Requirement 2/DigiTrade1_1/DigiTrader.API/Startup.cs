using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DigiTrader.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers(options =>
            //{
            //    options.Filters.Add(typeof(CustomExceptionFilterAttribute));
            //});
            services.AddControllers();//AddNewtonsoftJson(x =>x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            // Add this
            app.UseStatusCodePagesWithRedirects("/Error/404");
            app.UseExceptionHandler(new ExceptionHandlerOptions
            {
                ExceptionHandler = (c) => {
                    var exception = c.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exception.Error.GetType().Name switch
                    {
                        "ArgumentException" => HttpStatusCode.BadRequest,
                        _ => HttpStatusCode.ServiceUnavailable
                    };

                    c.Response.StatusCode = (int)statusCode;
                    var content = Encoding.UTF8.GetBytes($"Error [{exception.Error.Message}]");
                    c.Response.Body.WriteAsync(content, 0, content.Length);

                    return Task.CompletedTask;
                }
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

  
        //public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
        //{
        //    private readonly ILogger<CustomExceptionFilterAttribute> _logger;

        //    public CustomExceptionFilterAttribute(ILogger<CustomExceptionFilterAttribute> logger)
        //    {
        //        _logger = logger;
        //    }

        //    public override void OnException(ExceptionContext context)
        //    {
        //        base.OnException(context);

        //        // Some logic to handle specific exceptions
        //        var errorMessage = context.Exception is ArgumentException
        //            ? "ArgumentException occurred"
        //            : "Some unknown error occurred";

        //        // Maybe, logging the exception
        //        _logger.LogError(context.Exception, errorMessage);

        //        // Returning response
        //        context.Result = new BadRequestResult();
        //    }
        //}
    }


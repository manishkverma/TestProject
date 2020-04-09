using System.Web.Http;
using WebActivatorEx;
using CustomerManagement;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace CustomerManagement
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            GlobalConfiguration.Configuration
              .EnableSwagger(c => c.SingleApiVersion("v1", "Customer Management project APIs Demo"))
              .EnableSwaggerUi();
        }
    }
}

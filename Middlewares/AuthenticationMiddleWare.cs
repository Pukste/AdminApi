using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using UsingOptions.Models;
 
namespace gamewebapi.Middlewares
{
    public class AuthenticationMiddleware
    {
 
        private readonly MyOptions _options;
        private readonly RequestDelegate    _next;
 
        public AuthenticationMiddleware(RequestDelegate next, IOptions<MyOptions> optionAccessor){
 
            _options = optionAccessor.Value;
            _next = next;
        }
 
        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey("ApiKey"))
            {
 
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Missing ApiKey");
            }else if (!context.Request.Headers["ApiKey"].Equals(_options.ApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Wrong ApiKey");
            }
            else
            {
                await _next(context);
            }
        }
 
 
       
    }
}
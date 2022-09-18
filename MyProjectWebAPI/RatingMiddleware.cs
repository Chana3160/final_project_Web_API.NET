using DL;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectWebAPI
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RatingMiddleware
    {
        private readonly RequestDelegate _next;

        public RatingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, salseContext salseContext)
        {
            Rating r = new Rating();
            r.Host = httpContext.Request.Host.Value;
            r.Method = httpContext.Request.Method;
            r.Path = httpContext.Request.Path;
            r.Referer = httpContext.Request.Headers["Referer"];
            r.UserAgent = httpContext.Request.Headers["User-Agent"];
            r.RecordDate = DateTime.Now;
            await salseContext.Ratings.AddAsync(r);
            await salseContext.SaveChangesAsync();
            await _next(httpContext);
            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RatingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRatingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RatingMiddleware>();
        }
    }
}

using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTemplate.Presentation.Middlewares;

internal sealed class ExceptionsMiddleware
{
    private static ILogger<ExceptionsMiddleware> GetLogger(HttpContext context) =>
        (ILogger<ExceptionsMiddleware>)context.RequestServices.GetService(typeof(ILogger<ExceptionsMiddleware>))!;

    public static async Task Handler(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next.Invoke(context);
        }
        catch (Exception ex)
        {
            var logger = GetLogger(context);
            logger.LogError(ex, "Unexpected exception occurred.");

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        }
    }
}

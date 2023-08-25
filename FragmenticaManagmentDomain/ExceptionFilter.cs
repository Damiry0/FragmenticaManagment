using System.Web.Mvc;
using Microsoft.Extensions.Hosting;

namespace FragmenticaManagmentInfrastracture;

public class ExceptionFilter : IExceptionFilter
{
    private readonly IHostEnvironment _hostEnvironment;

    public ExceptionFilter(IHostEnvironment hostEnvironment) =>
        _hostEnvironment = hostEnvironment;

    public void OnException(ExceptionContext filterContext)
    {
        if (!_hostEnvironment.IsDevelopment())
        {
            return;
        }

        filterContext.Result = new ContentResult
        {
            Content = filterContext.Exception.ToString()
        };
    }
}
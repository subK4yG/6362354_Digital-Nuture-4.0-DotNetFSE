using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace Project3.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            File.AppendAllText("errors.txt", $"[{DateTime.Now}] {exception.Message}\n");
            context.Result = new ObjectResult("An error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}

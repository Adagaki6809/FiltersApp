using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersApp.Filters
{
    public class FakeNotFoundResourceFilter : Attribute, IResourceFilter
    {


        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            //context.Result = new ContentResult { Content = "Ресурс не найден" };
            //context.HttpContext.Response.Cookies.Append("anime", "kiznaiver");
        }
    }
}
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;

public class SimpleResourceFilter : Attribute, IResourceFilter
{
    ILogger _logger;
    int counter = 0;
    public SimpleResourceFilter(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger("SimpleResourceFilter");
    }
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        counter++;
        _logger.LogInformation($"OnResourceExecuted - {DateTime.Now}         counter: {counter}");
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        counter++;
        _logger.LogInformation($"OnResourceExecuting - {DateTime.Now}         counter: {counter}");
    }
}
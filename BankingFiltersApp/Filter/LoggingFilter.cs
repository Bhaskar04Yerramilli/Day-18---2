using Microsoft.AspNetCore.Mvc.Filters;
using BankingFiltersApp.Services;

namespace BankingFiltersApp.Filters
{
    public class LoggingFilter : IActionFilter
    {
        private readonly LoggingService _loggingService;

        public LoggingFilter(LoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _loggingService.Log(
                $"User accessed: {context.HttpContext.Request.Path}"
            );
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _loggingService.Log(
                $"Completed action at {DateTime.Now}"
            );
        }
    }
}
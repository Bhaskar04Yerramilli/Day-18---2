using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BankingFiltersApp.Services;

namespace BankingFiltersApp.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly LoggingService _loggingService;

        public ExceptionFilter(LoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnException(ExceptionContext context)
        {
            _loggingService.Log(context.Exception.Message);

            context.Result = new ViewResult
            {
                ViewName = "Error"
            };

            context.ExceptionHandled = true;
        }
    }
}
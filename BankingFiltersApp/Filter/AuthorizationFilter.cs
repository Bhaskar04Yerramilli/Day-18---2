using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BankingFiltersApp.Services;

namespace BankingFiltersApp.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        private readonly AuthService _authService;

        public AuthorizationFilter(AuthService authService)
        {
            _authService = authService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var role = _authService.GetUserRole();

            if (role != "Admin")
            {
                context.Result = new ContentResult
                {
                    Content = "Access Denied"
                };
            }
        }
    }
}
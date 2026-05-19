using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BankingFiltersApp.Services;

namespace BankingFiltersApp.Filters
{
    public class AuthenticationFilter : IAuthorizationFilter
    {
        private readonly AuthService _authService;

        public AuthenticationFilter(AuthService authService)
        {
            _authService = authService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!_authService.IsLoggedIn())
            {
                context.Result = new RedirectToActionResult(
                    "Login",
                    "Bank",
                    null
                );
            }
        }
    }
}
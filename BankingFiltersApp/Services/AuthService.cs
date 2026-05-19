namespace BankingFiltersApp.Services
{
    public class AuthService
    {
        public bool IsLoggedIn()
        {
            return true;
        }

        public string GetUserRole()
        {
            return "Admin";
        }
    }
}
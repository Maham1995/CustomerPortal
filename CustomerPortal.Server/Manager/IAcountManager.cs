using CustomerPortal.Server.Models;

namespace CustomerPortal.Server.Manager
{
    public interface IAccountManager
    {
        List<Account> CreateAccountData(Account acc);
        List<Account> GetbyAccountName(string name);
    }
}

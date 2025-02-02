using CustomerPortal.Server.DB;
using CustomerPortal.Server.Models;

namespace CustomerPortal.Server.Manager
{
    public class AccountManager : IAccountManager
    {
        private readonly ILogger<AccountManager> _logger;
        private readonly DatabaseConnection _connection;
        
        public AccountManager(ILogger<AccountManager> logger, DatabaseConnection connection) 
        {
            _logger = logger;
            _connection = connection;

        }

        public List<Account> CreateAccountData(Account acc) 
        {
            return new List<Account> {acc};
        }

        public List<Account> GetbyAccountName(string name) 
        {
            // var data = _context.Accounts.Where(n => n.name.Contains(name)).ToList();
            return null;
        }

        public List<Account> GetAccountData() 
        {
            //var data = _context.Accounts.Take(10).ToList();
            //return data;
            return null;
        }



    }
}

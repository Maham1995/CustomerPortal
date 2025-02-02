using CustomerPortal.Server.Manager;
using CustomerPortal.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerPortal.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IAccountManager _accountManager;

        public AccountController(ILogger logger, IAccountManager accountManager)
        {
            _logger = logger;
            _accountManager = accountManager;
        }

        //Using the onboard client button, the FE should call this endpoint for us to save new account details into the account table.
        [HttpPost(Name = "CreateAccount")]
        public List<Account> CreateAccount(Account acc)
        {
            var response = _accountManager.CreateAccountData(acc);
            return response;

        }

        //Search by account name to get List back from account table.
        [HttpGet(Name = "SearchByAccountName")]
        public List<Account> CreateAccount(string name)
        {
            var response = _accountManager.GetbyAccountName(name);
            return response;

        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using DataBaseLibrary;
using DataBaseLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ICandidateService service;
        // GET: api/Accounts
        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            var account = service.GetAccounts();
            return Ok(account);
        }
        public AccountsController(ICandidateService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async Task<ActionResult<AccountDTO>> CheckAccount([FromBody] AccountDTO dto)
        {

            Account account = service.GetAccountByCredentials(dto.UserName, dto.Password);
            AccountDTO found = new AccountDTO();
            if (account != null)
            {
                found.UserName = account.UserName;
                found.Password = account.Password;
            }
            return Ok(found);
        }
    }
}
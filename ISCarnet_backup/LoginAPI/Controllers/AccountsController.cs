using System.Collections.Generic;
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
            var accounts = service.GetAccounts();
            return Ok(accounts);
        }
        public AccountsController(ICandidateService service)
        {
            this.service = service;
        }
        [HttpPost]
        public ActionResult<AccountDTO> CheckAccount([FromBody] AccountDTO dto)
        {

            Account account = service.GetAccountByCredentials(dto.UserName, dto.Password);
            AccountDTO found = new AccountDTO();
            if (account != null)
            {
                found.UserName = account.UserName;
                found.Password = account.Password;
                return Ok(found);
            }
            else
                return NotFound();

        }
    }
}
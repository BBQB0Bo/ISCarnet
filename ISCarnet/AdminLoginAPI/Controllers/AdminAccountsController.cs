using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataBaseLibrary;
using DataBaseLibrary.Models;
using DataBaseLibrary.Services;
using DataBaseLibrary.DTOs;

namespace AdminLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAccountsController : ControllerBase
    {
        private readonly IAdminService service;
        // GET: api/Accounts
        public AdminAccountsController(IAdminService service)
        {
            this.service = service;
        }

        // GET: api/AdminAccounts
        [HttpGet]
        public ActionResult<IEnumerable<AdminAccount>> Getaccounts()
        {
            List<AccountDTO> accountDTOs = service.GetAccounts();
            if (accountDTOs.Count == 0)
                return NoContent();
            return Ok(accountDTOs);
        }

        // GET: api/AdminAccounts/5
        [HttpGet("{username}")]
        public ActionResult<AdminAccount> GetAdminAccount(string username)
        {
            var adminAccount = service.GetAccountByUsername(username);

            if (adminAccount == null)
            {
                return NotFound();
            }

            return Ok(adminAccount);
        }

        // PUT: api/AdminAccounts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public IActionResult PutAdminAccount([FromBody]AccountDTO adminAccount)
        {
            var account = service.GetAccountByCredentials(adminAccount.UserName, adminAccount.Password);
            if (account == null)
                return NotFound();
            return Ok(account);
        }

        // POST: api/AdminAccounts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<AdminAccount> PostAdminAccount([FromBody]AccountDTO adminAccount)
        {
            var account = service.RegisterAdmin(adminAccount);

            return CreatedAtAction(nameof(GetAdminAccount), new { username = account.UserName }, account);
        }

        /*  // DELETE: api/AdminAccounts/5
          [HttpDelete("{id}")]
          public async Task<ActionResult<AdminAccount>> DeleteAdminAccount(Guid id)
          {
              var adminAccount = await _context.accounts.FindAsync(id);
              if (adminAccount == null)
              {
                  return NotFound();
              }

              _context.accounts.Remove(adminAccount);
              await _context.SaveChangesAsync();

              return adminAccount;
          }

          private bool AdminAccountExists(Guid id)
          {
              return _context.accounts.Any(e => e.AccountId == id);
          }*/
    }
}

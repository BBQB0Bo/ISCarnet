using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseLibrary;
using DataBaseLibrary.DTOs;
using System.Collections.Generic;
using System;

namespace CandidateRegisterController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateRegisterController : ControllerBase
    {

        private readonly ICandidateService service;

        public CandidateRegisterController(ICandidateService service)
        {
            this.service = service;
        }



        // POST: api/CandidateRegistry
        [HttpPost]
        public ActionResult<Account> PostCandidateRegister([FromBody] RegisterCandidateDTO dto)
        {
            if (service.CNPAlreadyExists(dto.CNP))
                return BadRequest();
            AccountDTO account = service.RegisterCandidate(dto);
            return CreatedAtAction(nameof(GetAccountByUserName), new { username = account.UserName }, account);
        }


        // PUT: api/CandidateRegister/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidate(Guid id, Candidate candidate)
        {
            if (service.FindCandidateById(id) == null)
            {
                return NotFound();
            }

            if (service.UpdateCandidate(candidate) == false)
                return NotFound();


            return NoContent();
        }



        // DELETE: api/Register/cnp
        [HttpDelete("{id}")]
        public async Task<ActionResult<Candidate>> DeleteCandidateRegister(Guid id)
        {

            if (service.DeleteCandidateAndAccount(id) == false)
                return NotFound();

            return NoContent();
        }

        // GET: api/Accounts
        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetCandidateRegiter([FromBody] AccountDTO acc)
        {
            var account = service.GetAccountByCredentials(acc.UserName, acc.Password);
            return Ok(account);
        }

        // GET: api/Accounts
        [HttpGet("{username}")]
        public ActionResult<Account> GetAccountByUserName(string username)
        {
            var account = service.GetAccountByUserName(username);
            return Ok(account);
        }


    }
}

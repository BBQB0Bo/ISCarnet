using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseLibrary;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult<Candidate>> PostCandidateRegister(string firstname, string lastname, DateTime birthdate, string cnp, string accountPassword, string confirmPassword)
        {
            if (!accountPassword.Equals(confirmPassword) || service.FindCandidateByCNP(cnp) == null)
            {
                return BadRequest();
            }

          Guid idReturn =  service.RegisterCandidate(firstname, lastname, birthdate, cnp, accountPassword);

           // return Ok();

            return CreatedAtAction(nameof(idReturn), idReturn);
        }


        // PUT: api/CandidateRegister/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExam(Guid id, Candidate candidate)
        {
            if (service.FindCandidateById(id) == null)
            {
                return NotFound();
            }

            //service.Entry(candidate).State = EntityState.Modified;

            //try
            //{
            //    await service.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    throw;
            //}

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
        public async Task<ActionResult<IEnumerable<Account>>> GetCandidateRegiter()
        {
            return await service.GetAccounts();
        }

    }
}

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
            //if (!accountPassword.Equals(confirmPassword) || service.Candidates.FirstOrDefault(c => c.CNP == cnp) == null)
            //{
            //    return BadRequest();
            //}

            // Candidate c = Candidate.Create(firstname, lastname, birthdate, cnp, accountPassword);
            service.RegisterCandidate(firstname, lastname, birthdate, cnp, accountPassword);

            return Ok();

            //return CreatedAtAction(nameof(c), new { cnp = c.CNP }, c);
        }


        // PUT: api/CandidateRegister/id
        [HttpPut("{cnp}")]
        public async Task<IActionResult> PutExam(string cnp, Candidate candidate)
        {
            //if (service.Candidates.FirstOrDefault(c => c.CNP == cnp) == null)
            //{
            //    return NotFound();
            //}

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
        [HttpDelete("{cnp}")]
        public async Task<ActionResult<Candidate>> DeleteCandidateRegister(string cnp)
        {

            //Candidate candidate = service.Candidates.FirstOrDefault(c => c.CNP == cnp);
            //if (candidate == null)
            //{
            //    return NotFound();
            //}

            //service.Candidates.Remove(candidate);
            //await service.SaveChangesAsync();

            return NoContent();
            //return CreatedAtAction(nameof(candidate), new { cnp = candidate.CNP }, candidate);
        }

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetCandidateRegiter()
        {
            return null;
        }

    }
}

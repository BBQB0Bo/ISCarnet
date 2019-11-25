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

        private readonly CandidateContext _context;

        public CandidateRegisterController(CandidateContext context)
        {
            _context = context;
        }



        // POST: api/CandidateRegistry
        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidateRegister(string firstname, string lastname, DateTime birthdate, string cnp, string accountPassword, string confirmPassword)
        {
            if (!accountPassword.Equals(confirmPassword) || _context.Candidates.FirstOrDefault(c => c.CNP == cnp) == null)
            {
                return BadRequest();
            }

            Candidate c = Candidate.Create(firstname, lastname, birthdate, cnp, accountPassword);
            _context.Candidates.Add(c);
            _context.Accounts.Add(c.UserAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(c), new { cnp = c.CNP }, c);
        }


        // PUT: api/CandidateRegister/id
        [HttpPut("{cnp}")]
        public async Task<IActionResult> PutExam(string cnp, Candidate candidate)
        {
            if (_context.Candidates.FirstOrDefault(c => c.CNP == cnp) == null)
            {
                return NotFound();
            }

            _context.Entry(candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }



        // DELETE: api/Register/cnp
        [HttpDelete("{cnp}")]
        public async Task<ActionResult<Candidate>> DeleteCandidateRegister(string cnp)
        {

            Candidate candidate = _context.Candidates.FirstOrDefault(c => c.CNP == cnp);
            if (candidate == null)
            {
                return NotFound();
            }

            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(candidate), new { cnp = candidate.CNP }, candidate);
        }

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetCandidateRegiter()
        {
            return await _context.Accounts.ToListAsync();
        }

    }
}

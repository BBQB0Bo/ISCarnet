using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataBaseLibrary;
using DataBaseLibrary.Models;
using DataBaseLibrary.DTOs;

namespace ExaminatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminatorsController : ControllerBase
    {
        private readonly ICandidateService service;

        public ExaminatorsController(ICandidateService service)
        {
            this.service = service;
        }

        // GET: api/Examinators
        [HttpGet]
        public async Task<ActionResult<List<ExaminatorDTO>>> GetExaminators()
        {
            return service.GetExaminatorDTOs();
        }

        // GET: api/Examinators/5
        [HttpGet("{fullName}")]
        public async Task<ActionResult<ExaminatorDTO>> GetExaminator(string fullName)
        {
            var examinator = service.GetExaminatorByName(fullName);

            if (examinator == null)
            {
                return NotFound();
            }

            return examinator;
        }

        // PUT: api/Examinators/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /*[HttpPut("{id}")]
        public async Task<IActionResult> PutExaminator(Guid id, Examinator examinator)
        {
            if (id != examinator.ExaminatorId)
            {
                return BadRequest();
            }

            _context.Entry(examinator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminatorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        */
        // POST: api/Examinators
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Examinator>> PostExaminator([FromBody]ExaminatorDTO dto)
        {
            ExaminatorDTO newExaminator = service.RegisterExaminator(dto);
            return CreatedAtAction(nameof(GetExaminator), new { fullName = newExaminator.FirstName + newExaminator.LastName }, newExaminator);
        }

        // DELETE: api/Examinators/5
        /*   [HttpDelete("{id}")]
           public async Task<ActionResult<Examinator>> DeleteExaminator(Guid id)
           {
               var examinator = await _context.Examinators.FindAsync(id);
               if (examinator == null)
               {
                   return NotFound();
               }

               _context.Examinators.Remove(examinator);
               await _context.SaveChangesAsync();

               return examinator;
           }

           private bool ExaminatorExists(Guid id)
           {
               return _context.Examinators.Any(e => e.ExaminatorId == id);
           }*/
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseLibrary;
using MediatR;
using DataBaseLibrary.DTOs.PastExam;
using System.Collections.Generic;

namespace PastExamsAPI.Controllers
{
    [Route("api/pastExam")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ExamsController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        // GET: api/Exams
        [HttpGet]
        public async Task<ActionResult<List<ExamDTO>>> GetExam()
        {
            var exams = await mediator.Send(new GetAllExams());
            if (exams == null)
            {
                return NotFound();
            }
            return Ok(exams);
        }

        // GET: api/Exams/5
        [HttpGet("{userName}")]
        public async Task<ActionResult<List<ExamDTO>>> GetExam(String userName)
        {
            var exams = await mediator.Send(new GetExamsCandidate(userName));
            if (exams == null)
            {
                return NotFound();
            }
            return Ok(exams);
        }

        // PUT: api/Exams/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut()]
        public async Task<ActionResult<ExamDTO>> PutExam([FromBody]UpdateExam request)
        {
            var exam = await mediator.Send(request);

            return exam;
        }

        // POST: api/Exams
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ExamDTO>> PostExam([FromBody]CreateExam request)
        {
                   
                var exam = await mediator.Send(request);
            if (exam == null)
                return NotFound("Candidate not found.");

                return exam;
                      
        }

        // DELETE:
        [HttpDelete()]
        public async Task<IActionResult> DeleteExam([FromBody]DeleteExam request)
        {
            try
            {
                await mediator.Send(request);
            }
            catch (Exception e)
            {
              return NotFound("Examen to delete not found"); 
            }
            return NoContent();
        }


    }
}

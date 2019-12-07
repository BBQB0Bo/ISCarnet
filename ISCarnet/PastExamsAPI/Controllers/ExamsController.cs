using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseLibrary;
using MediatR;
using PastExamsAPI.DTOs;


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
        public async Task<ActionResult<Exam>> GetExam()
        {
            var exams = await mediator.Send(new GetExams());
            if (exams == null)
            {
                return NotFound();
            }
            return Ok(exams);
        }

        // GET: api/Exams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> GetExam(Guid id)
        {
            var exams = await mediator.Send(new GetExam(id));
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
        public async Task<ActionResult<Exam>> PutExam([FromBody]UpdateExam request)
        {
            var exam = await mediator.Send(request);

            return exam;
        }

        // POST: api/Exams
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Exam>> PostExam([FromBody]CreateExam request)
        {
            var exam = await mediator.Send(request);

            return exam;
        }

        // DELETE:
        [HttpDelete()]
        public async Task<IActionResult> DeleteExam([FromBody]DeleteExam request)
        {
            await mediator.Send(request);
            return NoContent();
        }


    }
}

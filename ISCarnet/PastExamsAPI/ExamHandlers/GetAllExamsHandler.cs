using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetAllExamsHandler : IRequestHandler<GetAllExams, List<Exam>>
    {
      
            private readonly CandidateContext context;

            public GetAllExamsHandler(CandidateContext context)
            {
                this.context = context;
            }

        public async Task<List<Exam>> Handle(GetAllExams request, CancellationToken cancellationToken)
        {
            var exams = await context.Exams.ToListAsync();

            return exams;
        }
    }
}

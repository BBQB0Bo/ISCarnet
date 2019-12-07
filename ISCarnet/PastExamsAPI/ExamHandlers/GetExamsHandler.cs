using DataBaseLibrary;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PastExamsAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetExamsHandler : IRequestHandler<GetExams, List<Exam>>
    {
      
            private readonly CandidateContext context;

            public GetExamsHandler(CandidateContext context)
            {
                this.context = context;
            }

        public async Task<List<Exam>> Handle(GetExams request, CancellationToken cancellationToken)
        {
            var exams = await context.Exams.ToListAsync();
            return exams;
        }
    }
}

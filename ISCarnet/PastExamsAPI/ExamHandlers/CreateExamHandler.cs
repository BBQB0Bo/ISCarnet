using DataBaseLibrary;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PastExamsAPI.DTOs;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class CreateExamHandler : IRequestHandler<CreateExam, Exam>
    {
        private readonly CandidateContext context;

        public CreateExamHandler(CandidateContext context)
        {
            this.context = context;
        }
        public async Task<Exam> Handle(CreateExam request, CancellationToken cancellationToken)
        {
          /*  var candidate = await context.Candidates.SingleOrDefaultAsync(p => p.CNP == request.Candidate.CNP);
            if (candidate == null)
            {
                throw new Exception("Candidate doesn't exists");
            }*/
            var exam = Exam.Create(request.ExamDate, request.Score, request.Candidate);
            context.Exams.Add(exam);
            await context.SaveChangesAsync(cancellationToken);
            return exam;
        }
    }
}

using DataBaseLibrary;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using DataBaseLibrary.DTOs.PastExam;
using System;
using Microsoft.EntityFrameworkCore;

namespace PastExamsAPI.ExamHandlers
{
    public class CreateExamHandler : IRequestHandler<CreateExam, ExamDTO>
    {
        private readonly CandidateContext context;

        public CreateExamHandler(CandidateContext context)
        {
            this.context = context;
        }
        public async Task<ExamDTO> Handle(CreateExam request, CancellationToken cancellationToken)
        {
              var candidate = await context.Candidates.SingleOrDefaultAsync(p => p.CNP == request.Candidate.CNP);
              if (candidate == null)
              {
                  throw new Exception("Candidate doesn't exists");
              }
            var exam = Exam.Create(request.ExamDate, request.Score, request.Candidate);
            context.Exams.Add(exam);
            await context.SaveChangesAsync(cancellationToken);
            ExamDTO examReturn = new ExamDTO(exam);
            return examReturn;
        }
    }
}

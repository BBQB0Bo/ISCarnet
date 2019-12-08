using DataBaseLibrary;
using MediatR;
using DataBaseLibrary.DTOs.PastExam;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class DeleteExamHandler : IRequestHandler<DeleteExam>
    {
        private readonly CandidateContext context;

        public DeleteExamHandler(CandidateContext context)
        {
            this.context = context;
        }
        public async Task<Unit> Handle(DeleteExam request, CancellationToken cancellationToken)
        {
            var exam = context.Exams.SingleOrDefault(p => p.ExamDate == request.ExamDate && p.Candidate == request.Candidate);
            if (exam == null)
            {
                throw new Exception("Record doesn't exists");
            }

            context.Exams.Remove(exam);
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }

    }
}

using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class UpdateExamHandler : IRequestHandler<UpdateExam, ExamDTO>

    {
        private readonly CandidateContext context;

        public UpdateExamHandler(CandidateContext context)
        {
            this.context = context;
        }

        public async Task<ExamDTO> Handle(UpdateExam request, CancellationToken cancellationToken)
        {
            var exam = context.Exams.SingleOrDefault(p => p.ExamId == request.ExamId);
            if (exam == null)
            {
                throw new Exception("Record doesn't exists");
            }
            exam.Update(request.ExamDate, request.Score, request.Candidate);
            await context.SaveChangesAsync(cancellationToken);

            ExamDTO examReturn = new ExamDTO(exam);
            return examReturn;

        }

    }
}

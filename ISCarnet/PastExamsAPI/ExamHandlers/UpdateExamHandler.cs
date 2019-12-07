using DataBaseLibrary;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PastExamsAPI.DTOs;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class UpdateExamHandler : IRequestHandler<UpdateExam, Exam>

    {
        private readonly CandidateContext context;

        public UpdateExamHandler(CandidateContext context)
        {
            this.context = context;
        }

        public async Task<Exam> Handle(UpdateExam request, CancellationToken cancellationToken)
        {
            var exam = context.Exams.SingleOrDefault(p => p.ExamId == request.ExamId);
            if (exam == null)
            {
                throw new Exception("Record doesn't exists");
            }
            exam.Update(request.ExamDate, request.Score, request.Candidate);
            await context.SaveChangesAsync(cancellationToken);
            return exam;
        }

    }
}

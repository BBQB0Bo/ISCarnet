using DataBaseLibrary;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PastExamsAPI.DTOs;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetExamHandler : IRequestHandler<GetExam, Exam>
    {

        private readonly CandidateContext context;

        public GetExamHandler(CandidateContext context)
        {
            this.context = context;
        }
        public async Task<Exam> Handle(GetExam request, CancellationToken cancellationToken)
        {
            var exam = await context.Exams.SingleOrDefaultAsync(p => p.ExamId == request.ExamId);
            if (exam == null)
            {
                throw new Exception("Record doesn't exist");
            }
            return exam;
        }


    }
 }

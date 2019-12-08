using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetExamsCandidateHandler : IRequestHandler<GetExamsCandidate, List<ExamDTO>>
    {

        private readonly CandidateContext context;

        public GetExamsCandidateHandler(CandidateContext context)
        {
            this.context = context;
        }
        public async Task<List<ExamDTO>> Handle(GetExamsCandidate request, CancellationToken cancellationToken)
        {
            var exams = await context.Exams.Where(p => p.Candidate.UserAccount.UserName == request.userNameCandidate).ToListAsync();

            List<ExamDTO> examReturn = new List<ExamDTO>();
            foreach (Exam e in exams)
                examReturn.Add(new ExamDTO(e));

            return examReturn;

        }


    }
 }

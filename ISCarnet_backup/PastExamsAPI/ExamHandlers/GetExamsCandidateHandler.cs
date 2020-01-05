using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetExamsCandidateHandler : IRequestHandler<GetExamsCandidate, List<ExamDTO>>
    {

        private readonly IExamService service;
        public GetExamsCandidateHandler(IExamService service)
        {
            this.service = service;
        }
        public async Task<List<ExamDTO>> Handle(GetExamsCandidate request,CancellationToken cancellationToken)
        {
            //returneaza toate examenele asociate unui username
            var exams = await service.GetExamsByUsername (request, cancellationToken);

            List<ExamDTO> examReturn = new List<ExamDTO>();
            foreach (Exam e in exams)
                examReturn.Add(new ExamDTO(e));

            return examReturn;

        }


    }
 }

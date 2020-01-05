using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetAllExamsHandler : IRequestHandler<GetAllExams, List<ExamDTO>>
    {

        private readonly IExamService service;
        public GetAllExamsHandler(IExamService service)
        {
            this.service = service;
        }

        public async Task<List<ExamDTO>> Handle(GetAllExams request, CancellationToken cancellationToken)
        {
            List<ExamDTO> output = new List<ExamDTO> { };
            var exams =  await service.GetExams();
            foreach (Exam e in exams) {
                ExamDTO examDTO = new ExamDTO(e);
                output.Add(examDTO);

            }
            return output;
            
          
        }
    }
}

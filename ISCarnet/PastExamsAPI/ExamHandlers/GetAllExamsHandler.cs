using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class GetAllExamsHandler : IRequestHandler<GetAllExams, List<Exam>>
    {

        private readonly IExamService service;
        public GetAllExamsHandler(IExamService service)
        {
            this.service = service;
        }

        public async Task<List<Exam>> Handle(GetAllExams request, CancellationToken cancellationToken)
        {
            return await service.GetExams();
            
          
        }
    }
}

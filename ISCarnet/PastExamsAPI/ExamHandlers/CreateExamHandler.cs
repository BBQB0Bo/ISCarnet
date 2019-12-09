using DataBaseLibrary;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using DataBaseLibrary.DTOs.PastExam;
using System;

namespace PastExamsAPI.ExamHandlers
{
    public class CreateExamHandler : IRequestHandler<CreateExam, ExamDTO>
    {
        private readonly IExamService service;
        public CreateExamHandler(IExamService service)
        {
            this.service = service;
        }
        public async Task<ExamDTO> Handle(CreateExam request, CancellationToken cancellationToken)
        {
                Exam ex = await service.AddExam(request.ExamDate, request.Score, request.CNP, cancellationToken);
                 if (ex == null)
                return null;

                ExamDTO examReturn = new ExamDTO(ex);
                return examReturn;

        }
    }
}

using DataBaseLibrary;
using DataBaseLibrary.DTOs.PastExam;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PastExamsAPI.ExamHandlers
{
    public class UpdateExamHandler : IRequestHandler<UpdateExam, ExamDTO>

    {
        private readonly IExamService service;
        public UpdateExamHandler(IExamService service)
        {
            this.service = service;
        }

        public async Task<ExamDTO> Handle(UpdateExam request,CancellationToken cancellationToken)
        {
           Exam exam = await service.ExamUpdate(request, cancellationToken);

            ExamDTO examReturn = new ExamDTO(exam);
            return examReturn;

        }

    }
}

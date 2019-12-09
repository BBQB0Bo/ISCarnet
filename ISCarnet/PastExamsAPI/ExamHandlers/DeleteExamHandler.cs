using DataBaseLibrary;
using MediatR;
using DataBaseLibrary.DTOs.PastExam;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace PastExamsAPI.ExamHandlers
{
    public class DeleteExamHandler : IRequestHandler<DeleteExam>
    {
        private readonly IExamService service;
        public DeleteExamHandler(IExamService service)
        {
            this.service = service;
        }
        public async Task<Unit> Handle(DeleteExam request, CancellationToken cancellationToken)
        {
            try {
                await service.DeleteExam(request, cancellationToken);
                return Unit.Value;

            } catch (Exception e)
            {
                throw new Exception("Record doesn't exists");
            }
        }
           
        }

    }

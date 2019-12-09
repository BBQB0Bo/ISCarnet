using DataBaseLibrary;
using MediatR;
using DataBaseLibrary.DTOs.PastExam;
using System.Threading;
using System.Threading.Tasks;

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
          await service.DeleteExam(request, cancellationToken);
            return Unit.Value;
        }

    }
}

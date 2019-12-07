using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastExamsAPI.DTOs
{
    public class DeleteExam : IRequest

    {
        public Guid ExamId { get;  set; }
    }
}

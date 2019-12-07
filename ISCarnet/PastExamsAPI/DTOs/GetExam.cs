using DataBaseLibrary;
using MediatR;
using System;

namespace PastExamsAPI.DTOs
{
    public class GetExam : IRequest <Exam>
    {
        public Guid ExamId { get; }

        public GetExam(Guid examid)
        {
            ExamId = examid;
        }
    }
}

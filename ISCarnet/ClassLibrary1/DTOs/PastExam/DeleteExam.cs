using MediatR;
using System;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class DeleteExam : IRequest

    {
        public DateTime ExamDate { get; set; }
        public String CNP { get; set; }
    }
}

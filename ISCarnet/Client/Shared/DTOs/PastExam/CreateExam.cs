using Client.Shared.Models;
using MediatR;
using System;


namespace Client.Shared.DTOs.PastExam
{
    public class CreateExam : IRequest<ExamDTO>
    {
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
        public String usernameCandidate { get; set; }

        public String ExaminatorName { get; set; }

    }
}

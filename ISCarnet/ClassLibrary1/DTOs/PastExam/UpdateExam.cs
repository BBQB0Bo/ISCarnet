using DataBaseLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class UpdateExam : IRequest<ExamDTO>
    {
        public DateTime ExamDate { get; set; }
        public String UsernameCandidate { get; set; }
        public List<MistakeDTO> Mistakes { get; set; }
        public Boolean Absent { get; set; }

        public UpdateExam()
        {
            this.Mistakes = new List<MistakeDTO>();
        }

    }
}

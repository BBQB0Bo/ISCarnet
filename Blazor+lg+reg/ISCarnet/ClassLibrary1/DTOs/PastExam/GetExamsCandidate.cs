using DataBaseLibrary;
using MediatR;
using System;
using System.Collections.Generic;

namespace DataBaseLibrary.DTOs.PastExam
{
    //toate examenele unui candidat
    public class GetExamsCandidate : IRequest <List<ExamDTO>>
    {
        private string userName;

        public GetExamsCandidate(string userName)
        {
            this.userName = userName;
        }

        public String userNameCandidate { get; set; }



   
    }
}

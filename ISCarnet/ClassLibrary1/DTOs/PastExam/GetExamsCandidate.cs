using DataBaseLibrary;
using MediatR;
using System;
using System.Collections.Generic;

namespace DataBaseLibrary.DTOs.PastExam
{
    //toate examenele unui candidat
    public class GetExamsCandidate : IRequest <List<ExamDTO>>
    {

        public GetExamsCandidate(string userName)
        {
            this.userNameCandidate = userName;
        }

        public String userNameCandidate { get; set; }



   
    }
}

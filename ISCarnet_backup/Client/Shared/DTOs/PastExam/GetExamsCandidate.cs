using MediatR;
using System;
using System.Collections.Generic;

namespace Client.Shared.DTOs.PastExam
{
    //toate examenele unui candidat
    public class GetExamsCandidate : IRequest<List<ExamDTO>>
    {

        public GetExamsCandidate(string userName)
        {
            this.userNameCandidate = userName;
        }

        public String userNameCandidate { get; private set; }




    }
}

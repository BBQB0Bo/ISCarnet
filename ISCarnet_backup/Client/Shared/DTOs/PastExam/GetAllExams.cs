﻿using MediatR;
using System.Collections.Generic;

namespace Client.Shared.DTOs.PastExam
{
    // toate examenele din baza de date cu tot cu candidati ( pentru admin )
    public class GetAllExams : IRequest<List<ExamDTO>>
    {
    }
}

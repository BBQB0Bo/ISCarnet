using MediatR;
using System.Collections.Generic;

namespace DataBaseLibrary.DTOs.PastExam
{
    // toate examenele din baza de date cu tot cu candidati ( pentru admin )
    public class GetAllExams : IRequest <List<Exam>>
    {
    }
}

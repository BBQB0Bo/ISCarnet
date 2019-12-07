using DataBaseLibrary;
using MediatR;
using System.Collections.Generic;

namespace PastExamsAPI.DTOs
{
    public class GetExams : IRequest < List<Exam>>
    {
    }
}

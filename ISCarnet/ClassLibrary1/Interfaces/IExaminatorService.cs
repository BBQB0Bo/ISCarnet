using DataBaseLibrary.DTOs;
using System.Collections.Generic;

namespace DataBaseLibrary.Interfaces
{
    public interface IExaminatorService
    {
        public ExaminatorDTO RegisterExaminator(ExaminatorDTO dto);
        public List<ExaminatorDTO> GetExaminatorDTOs();

        public ExaminatorDTO GetExaminatorByName(string fullName);
    }
}

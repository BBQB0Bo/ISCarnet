using DataBaseLibrary.DTOs;
using DataBaseLibrary.Interfaces;
using DataBaseLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataBaseLibrary.Services
{
    public  class ExaminatorServices : IExaminatorService
    {
        public readonly CandidateContext context;

        public ExaminatorServices(CandidateContext context)
        {
            this.context = context;
        }

        public ExaminatorServices()
        {
            this.context = new CandidateContext();
        }

        public ExaminatorDTO RegisterExaminator(ExaminatorDTO dto)
        {
            Examinator examinator = Examinator.Create(dto.FirstName, dto.LastName);
            context.Examinators.Add(examinator);
            context.SaveChanges();
            dto = new ExaminatorDTO(examinator);
            return dto;
        }

        public List<ExaminatorDTO> GetExaminatorDTOs()
        {
            List<ExaminatorDTO> dtos = new List<ExaminatorDTO>();
            foreach (Examinator examinator in context.Examinators.ToList())
            {
                dtos.Add(new ExaminatorDTO(examinator));
            }
            return dtos;
        }

        public ExaminatorDTO GetExaminatorByName(string fullName)
        {
            Examinator ex = context.Examinators.FirstOrDefault(e => e.FirstName + e.LastName == fullName);
            ExaminatorDTO dto = new ExaminatorDTO(ex);
            return dto;
        }

    }
}

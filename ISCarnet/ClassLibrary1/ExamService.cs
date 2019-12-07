/*using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBaseLibrary
{
    public class ExamService : IExamService
    {
        private readonly CandidateContext context;

        public ExamService(CandidateContext context)
        {
            this.context = context;
        }

        // private CandidateContext context;

        public List<Exam> GetExams()
        {
          return context.Exams.ToList();
        }

        public Exam FindExamById(Guid id)
        {
            return context.Exams.FirstOrDefault(c => c.ExamId == id);
        }

        public bool AddExam(Exam exam)
        {
            if (FindExamById(exam.ExamId) != null)
                return false;
                

            context.Exams.Add(exam);
            context.SaveChanges();
            return true;
        }

        public bool DeleteExam(Guid id)
        {
            Exam exam = this.FindExamById(id);
            if (exam == null)
            {
                return false;
            }

            context.Exams.Remove(exam);
            context.SaveChanges();
            return true;
        }

        public bool ExamUpdate(Exam exam)
        {

            context.Entry(exam).State = EntityState.Modified;

            try
            {
                 context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (FindExamById(exam.ExamId) == null)
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }


    }
}
*/
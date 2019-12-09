using DataBaseLibrary.DTOs.PastExam;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class ExamService : IExamService
    {
        private readonly CandidateContext context;

        public ExamService(CandidateContext context)
        {
            this.context = context;
        }

        public async Task<List<Exam>> GetExams()
        {
            return await context.Exams.ToListAsync();
        }

        public async Task<List<Exam>> GetExamsByUsername(GetExamsCandidate request, CancellationToken cancellationToken)
        {
            return await context.Exams.Where(p => p.Candidate.UserAccount.UserName == request.userNameCandidate).ToListAsync();
        }

        public async Task<Exam> AddExam(DateTime examDate, int scoreExam, String cnp, CancellationToken cancellationToken)
        {
            var candidate = context.Candidates.SingleOrDefault(p => p.CNP == cnp);
            if (candidate == null)
            {
                return null;
            }

            var examen = Exam.Create(examDate, scoreExam, candidate);
            context.Exams.Add(examen);

            await context.SaveChangesAsync(cancellationToken);

            return examen;
        }

        public async Task<bool> DeleteExam(DeleteExam request, CancellationToken cancellationToken)
        {
            var exam = context.Exams.SingleOrDefault(p => p.ExamDate == request.ExamDate && p.Candidate.CNP == request.CNP);
            if (exam == null)
            {

                throw new Exception("Record doesn't exists");
            }
            context.Exams.Remove(exam);
            await context.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task<Exam> ExamUpdate(UpdateExam request, CancellationToken cancellationToken)
        {

            var exam = context.Exams.SingleOrDefault(p => p.ExamId == request.ExamId);
            if (exam == null)
            {
                throw new Exception("Record doesn't exists");
            }
            exam.Update(request.ExamDate, request.Score, request.Candidate);
            await context.SaveChangesAsync(cancellationToken);
            return exam;

        }


    }
}

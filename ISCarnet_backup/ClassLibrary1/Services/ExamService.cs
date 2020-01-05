using DataBaseLibrary.DTOs;
using DataBaseLibrary.DTOs.PastExam;
using DataBaseLibrary.Models;
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

        public async Task<Exam> AddExam(CreateExam request, CancellationToken cancellationToken)
        {
            var candidate = context.Candidates.SingleOrDefault(p => p.UserAccount.UserName == request.usernameCandidate);
            var examinator = context.Examinators.FirstOrDefault(e => e.FirstName + " " + e.LastName == request.ExaminatorName);
            var OldExam = false;
            OldExam = CheckExam(request);

            if (candidate == null || OldExam == true)
            {
                return null;
            }

            var examen = Exam.CreateFutureExam(request.ExamDate, candidate, examinator);
            context.Exams.Add(examen);

            await context.SaveChangesAsync(cancellationToken);

            return examen;
        }

        public async Task<bool> DeleteExam(DeleteExam request, CancellationToken cancellationToken)
        {
            var exam = context.Exams.SingleOrDefault(p => p.ExamDate == request.ExamDate && p.Candidate == request.Candidate);
            if (exam == null)
            {

                throw new Exception("Record doesn't exists");
            }
            exam.Examinator.RemoveExam(exam);
            exam.Candidate.RemoveExam(exam);
            context.Exams.Remove(exam);

            await context.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task<Exam> ExamUpdate(UpdateExam request, CancellationToken cancellationToken)
        {

            var exam = context.Exams.FirstOrDefault(p => p.ExamDate == request.ExamDate & request.UsernameCandidate == p.Candidate.UserAccount.UserName);
            if (exam == null)
            {
                return null;
            }
            if (request.Absent == true)
            {
                ClearMistakes(exam);
                exam.AbsentCandidate();
                exam.Examinator.updatePercentage();
                await context.SaveChangesAsync(cancellationToken);
                return null;
            }
            ClearMistakes(exam);
            foreach (MistakeDTO m in request.Mistakes)
            {
                Mistake mistake = new Mistake(m, exam);
                context.Mistakes.Add(mistake);
                //exam.AttachMistake(mistake);
            }
            exam.Update();
            exam.Examinator.updatePercentage();

            await context.SaveChangesAsync(cancellationToken);
            return exam;

        }
        public bool CheckExam(CreateExam request)
        {
            var result = context.Exams.Where(e => e.ExamDate == request.ExamDate & e.Candidate.UserAccount.UserName == request.usernameCandidate);
            if (result == null)
                return true;
            return false;
        }

        public void ClearMistakes(Exam e)
        {
            foreach (Mistake m in e.Mistakes)
            {
                context.Mistakes.Remove(m);
            }
            context.SaveChanges();
            e.DeleteMistakes();

        }




    }
}

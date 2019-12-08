using DataBaseLibrary.DTOs.PastExam;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public interface IExamService
    {
        public Task<List<Exam>> GetExams();
        public Task<List<Exam>> GetExamsByUsername(GetExamsCandidate request, CancellationToken cancellationToken);

        public Task<Exam> AddExam(DateTime examDate, int scoreExam, String cnp, CancellationToken cancellationToken) ;

        public Task<bool> DeleteExam(DeleteExam request, CancellationToken cancellationToken);
        public Task<Exam> ExamUpdate(UpdateExam request, CancellationToken cancellationToken);


    }
}

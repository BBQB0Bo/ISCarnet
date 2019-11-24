using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary
{
    public class ExamDisplay
    {
        private ExamDisplay() { }

        public DateTime ExamDate { get; private set; }
        public int Score { get; private set; }
        public string Result { get; private set; }

        public static ExamDisplay Create(Exam Model)
        {
            return new ExamDisplay { ExamDate = Model.ExamDate, Score = Model.Score, Result = Model.Result };
        }
    }
}

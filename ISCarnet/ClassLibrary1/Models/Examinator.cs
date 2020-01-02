using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseLibrary.Models
{
    public class Examinator
    {
        public Guid ExaminatorId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public float PassingPercentage { get; private set; }
        public virtual List<Exam> Exams { get; private set; }
        public Examinator()
        {
            Exams = new List<Exam>();
        }
        public static Examinator Create(string firstname, string lastname)
        {
            Examinator examinator = new Examinator
            {
                ExaminatorId = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                Exams = new List<Exam>()
            };
            examinator.updatePercentage();
            return examinator;
        }
        public void updatePercentage()
        {
            if (Exams.Count == 0)
            {
                PassingPercentage = 100;
            }
            else
            {
                float totalExams = (float)Exams.Count;
                float passedExams = (float)Exams.Where(e => e.Score >= 21).ToList().Count;
                PassingPercentage = passedExams / totalExams * 100;
            }

        }
        public void AttachExam(Exam e)
        {
            // delete later : whern admin api is made
            this.Exams.Add(e);
            this.updatePercentage();
        }
        public void RemoveExam(Exam e)
        {
            Exams.Remove(e);
            this.updatePercentage();
        }
    }
}

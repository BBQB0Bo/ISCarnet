using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.Models
{
    public class Mistake
    {
        public string MistakeType { get; private set; }
        public int Score { get; private set; }
        public Exam Exam { get; private set; }
    }
}

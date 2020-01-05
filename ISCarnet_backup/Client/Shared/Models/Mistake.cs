using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Shared.Models
{
    public class Mistake
    {
        public Guid MistakeId { get; private set; }
        public string MistakeType { get; private set; }
        public int Score { get; private set; }
        public Exam Exam { get; private set; }
    }
}

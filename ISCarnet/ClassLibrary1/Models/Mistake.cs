﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.Models
{
    public class Mistake
    {
        public Guid MistakeId { get; private set; }
        public string MistakeType { get; private set; }
        public int Score { get; private set; }
        public virtual Exam Exam { get; private set; }
        public Mistake() { }
    }
}

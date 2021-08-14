﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QAProject2.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public Tag()
        {
            Questions = new HashSet<Question>();
        }
    }
}
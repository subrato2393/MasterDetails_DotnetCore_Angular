﻿using System;
using System.Collections.Generic;
 
namespace AssignmentApp.Domain
{
    public  class Gender
    {
        public Gender()
        {
            Members = new HashSet<Member>();
        }

        public int GenderId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}

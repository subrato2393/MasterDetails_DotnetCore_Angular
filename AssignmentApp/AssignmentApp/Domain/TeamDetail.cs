﻿using System;
using System.Collections.Generic;

namespace AssignmentApp.Domain
{
    public class TeamDetail
    {
        public TeamDetail()
        {
            Members = new HashSet<Member>();
        }

        public int TeamDetailsId { get; set; }
        public string? TeamName { get; set; }
        public string? TeamDescription { get; set; }
        public int? ApprovedByDirector { get; set; }
        public int? AprovedByManager { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace AssignmentApp.DTOs
{  
    public class TeamMemberDto
    {
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? ContactNo { get; set; }
        public int? GenderId { get; set; }
    }
}
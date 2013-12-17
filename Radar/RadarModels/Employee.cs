﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RadarModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
        public Nullable<DateTime> DeletedDate { get; set; }

        public virtual Role Role { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
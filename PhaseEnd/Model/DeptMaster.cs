﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhaseEnd.Model
{
    
        [Table("DeptMaster")]
        public class DeptMaster
        {
            [Key]
            public int DeptCode { get; set; }

            public string DeptName { get; set; }

            public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
        }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("System_Country_Codes")]
    public class SystemCountryCodePoco:IPoco 
    {
        [Key]
        public string Code { get; set; }
        [Column("Name")]
        public string Name { get; set; }
            
        public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistory { get; set; }
        [NotMapped]
        public Guid Id { get; set; }
    }
}

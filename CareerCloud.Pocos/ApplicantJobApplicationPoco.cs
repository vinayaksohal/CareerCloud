using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Job_Applications")]
    public class ApplicantJobApplicationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [Column("Applicant")]
        public Guid Applicant { get; set; }
        [ForeignKey("Job")]
        public Guid Job { get; set; }
        [Column("Application_Date")]
        public DateTime ApplicationDate { get; set; }

        [Column("Time_Stamp")][Timestamp]
        public byte[] TimeStamp { get; set; }

        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }
        public virtual CompanyJobPoco CompanyJobs { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CompanyJobPoco")]
        public Guid Job { get; set; }
        [Column("Skill")]
        public string Skill { get; set; }
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        [Column("Importance")]
        public Int32 Importance { get; set; }
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual CompanyJobPoco CompanyJobs { get; set; }
    }
}

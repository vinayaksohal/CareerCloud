using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CompanyProfilePoco")]
        public Guid Company { get; set; }
        [Column("LanguageId")]
        public string LanguageId { get; set; }
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        [Column("Company_Description")]
        public string CompanyDescription { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

    }
}

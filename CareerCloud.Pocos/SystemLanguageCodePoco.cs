using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("System_Language_Codes")]
    public class SystemLanguageCodePoco:IPoco
    {
        [Key]
        public string LanguageID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Native_Name")]
        public string NativeName { get; set; }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

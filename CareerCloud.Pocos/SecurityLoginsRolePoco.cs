using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco :IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("SecurityLoginPoco")]
        public Guid Login { get; set; }
        [ForeignKey("SecurityRolePoco")]
        public Guid Role { get; set; }
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual SecurityLoginPoco SecurityLogins { get; set; }
        public virtual SecurityRolePoco SecurityRoles { get; set; }
    }
}

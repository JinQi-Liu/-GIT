using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MyProject.EntityFrameworkCore.Entity
{
    //[Table("Auth_Group")]
    public class AuthGroup:Entity<Guid>
    {
        //[Key]
        //[Column("ID")]
        //public override Guid Id { get; set; }

        //[MaxLength(50), Required]
        public string GroupName { get; set; }

        public virtual List<AuthGroupEmployeeInfo> AuthGroupEmployeeInfos { get; set; }
    }
}

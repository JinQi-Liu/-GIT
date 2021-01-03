using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MyProject.EntityFrameworkCore.Entity
{
    //[Table("HR_EmployeeInfo")]
    public class HREmployeeInfo: Entity<Guid>
    {
        //[Key]
        //[Column("ID")]
        //public override Guid Id { get; set; }

        //[MaxLength(50), Required]
        public string Name { get; set; }

        public virtual List<AuthGroupEmployeeInfo> AuthGroupEmployeeInfos { get; set; }
    }
}

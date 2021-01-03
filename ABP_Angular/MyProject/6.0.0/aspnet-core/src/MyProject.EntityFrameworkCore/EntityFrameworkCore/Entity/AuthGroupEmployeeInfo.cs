using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EntityFrameworkCore.Entity
{
    public class AuthGroupEmployeeInfo : Entity<Guid>
    {
        public Guid AuthGroupID { get; set; }
        public AuthGroup AuthGroup { get; set; }
        public Guid HREmployeeInfoID { get; set; }
        public HREmployeeInfo HREmployeeInfo { get; set; }
    }
}

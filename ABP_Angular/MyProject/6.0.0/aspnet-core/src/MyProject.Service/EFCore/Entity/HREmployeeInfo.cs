using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.EFCore.Entity
{
    [Table("HR_EmployeeInfo")]
    public class HREmployeeInfo : Entity<Guid>
    {
        [Key]
        [Column("ID")]
        public override Guid Id { get; set; }

        [MaxLength(50), Required]
        public string Name { get; set; }

        public virtual List<AuthGroupEmployeeInfo> AuthGroupEmployeeInfos { get; set; }
    }
}

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
    [Table("Auth_Group")]
    public class AuthGroup : Entity<Guid>
    {
        [Key]
        [Column("ID")]
        public override Guid Id { get; set; }

        [MaxLength(20), Required]
        public string GroupName { get; set; }

        public List<AuthGroupEmployeeInfo> AuthGroupEmployeeInfos { get; set; }
    }
}

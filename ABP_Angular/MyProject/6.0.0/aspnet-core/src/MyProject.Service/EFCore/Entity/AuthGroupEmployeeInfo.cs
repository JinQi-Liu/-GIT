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
    [Table("Auth_GroupEmployeeInfo")]
    public class AuthGroupEmployeeInfo : Entity<Guid>
    {
        [Key]
        [Column("ID")]
        public override Guid Id { get; set; }
        public Guid AuthGroupID { get; set; }
        [ForeignKey("AuthGroupID")]
        public AuthGroup AuthGroup { get; set; }
        public Guid HREmployeeInfoID { get; set; }
        [ForeignKey("HREmployeeInfoID")]
        public HREmployeeInfo HREmployeeInfo { get; set; }
    }
}

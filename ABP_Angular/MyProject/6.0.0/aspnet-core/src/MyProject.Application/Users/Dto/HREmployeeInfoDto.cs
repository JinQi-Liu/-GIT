using Abp.AutoMapper;
using MyProject.Service.EFCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Users.Dto
{
    [AutoMapFrom(typeof(HREmployeeInfo))]
    public class HREmployeeInfoDto
    {
        public string Name { get; set; }
    }
}

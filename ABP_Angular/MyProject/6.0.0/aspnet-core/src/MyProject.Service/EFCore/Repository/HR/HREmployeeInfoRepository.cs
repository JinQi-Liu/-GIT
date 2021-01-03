using Abp.EntityFrameworkCore;
using MyProject.Service.EFCore.Entity;
using MyProject.Service.EFCore.RepositoryInterface.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.EFCore.Repository.HR
{
    public class HREmployeeInfoRepository : WMPRepositoryBase<HREmployeeInfo> , IHREmployeeInfoRepository
    {
        public HREmployeeInfoRepository(IDbContextProvider<WMPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}

using Abp.EntityFrameworkCore;
using MyProject.EFCore.Entity;
using MyProject.EFCore.RepositoryInterface.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EFCore.Repository.HR
{
    public class HREmployeeInfoRepository : WMPRepositoryBase<HREmployeeInfo> , IHREmployeeInfoRepository
    {
        public HREmployeeInfoRepository(IDbContextProvider<WMPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}

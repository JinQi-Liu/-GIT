using Abp.Domain.Repositories;
using MyProject.Service.DAO.Auth;
using MyProject.Service.EFCore.Entity;
using MyProject.Service.EFCore.RepositoryInterface.Auth;
using MyProject.Service.EFCore.RepositoryInterface.HR;
using MyProject.Service.ServiceInterface.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.Service.Auth
{
    public class AuthGroupEmployeeInfoService: IAuthGroupEmployeeInfoService
    {
        private readonly IAuthGroupEmployeeInfoRepository _authGroupEmployeeInfoRepository;
        private readonly IAuthGroupRepository _authGroupRepository;
        private readonly IHREmployeeInfoRepository _hREmployeeInfoRepository;

        public AuthGroupEmployeeInfoService(IAuthGroupEmployeeInfoRepository authGroupEmployeeInfoRepository
            , IAuthGroupRepository authGroupRepository
            , IHREmployeeInfoRepository hREmployeeInfoRepository)
        {
            _authGroupEmployeeInfoRepository = authGroupEmployeeInfoRepository;
            _authGroupRepository = authGroupRepository;
            _hREmployeeInfoRepository = hREmployeeInfoRepository;
        }

        public List<HREmployeeInfo> Test()
        {
            #region EF
            /*
            AuthGroup authGroup = new AuthGroup()
            {
                Id = new Guid()
                ,
                GroupName = "测试权限组"
            };

            HREmployeeInfo hREmployeeInfo = new HREmployeeInfo()
            {
                Id = new Guid(),
                Name = "刘锦旗"
            };

            _authGroupRepository.Insert(authGroup);
            _hREmployeeInfoRepository.Insert(hREmployeeInfo);
            _authGroupEmployeeInfoRepository.Insert(new AuthGroupEmployeeInfo()
            {
                HREmployeeInfo = hREmployeeInfo,
                AuthGroup = authGroup
            });
            */
            List<HREmployeeInfo> eList = _hREmployeeInfoRepository.GetAllListAsync().Result;
            return eList;
            #endregion


            #region ADO

            //DataTable dt = new AuthGroupEmployeeInfoDAO().GetAllEmployee();
            #endregion
        }
    }
}

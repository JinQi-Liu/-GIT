using AutoMapper;
using MyProject.Authorization.Users;
using MyProject.Service.EFCore.Entity;
using System.Collections.Generic;

namespace MyProject.Users.Dto
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<UserDto, User>()
                .ForMember(x => x.Roles, opt => opt.Ignore())
                .ForMember(x => x.CreationTime, opt => opt.Ignore());

            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

            CreateMap<HREmployeeInfoDto, HREmployeeInfo>();
        }
    }
}

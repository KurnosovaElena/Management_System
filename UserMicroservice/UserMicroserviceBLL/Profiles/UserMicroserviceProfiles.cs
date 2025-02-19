using AutoMapper;
using UserMicroserviceBLL.DTO;
using UserMicroserviceBLL.DTO.CreateDTO;
using UserMicroserviceDAL.Entities;

namespace UserMicroserviceBLL.Profiles;

public class UserMicroserviceProfiles : Profile
{
    public UserMicroserviceProfiles()
    {
        CreateMap<CreateUserDto, UserEntity>();
        CreateMap<UserEntity, UserDto>();
    }
}

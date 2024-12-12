using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using DAL.Entities;

namespace BLL.Profiles;

public class SubtaskProfile : Profile
{
    public SubtaskProfile()
    {
        CreateMap<CreateSubtaskDTO, SubtaskEntity>();
        CreateMap<SubtaskEntity, SubtaskDTO>();
    }
}
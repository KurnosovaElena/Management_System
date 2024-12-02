using AutoMapper;
using BLL.DTO.CreateDTO;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Profiles;
public class LabelProfile : Profile
{
    public LabelProfile()
    {
        CreateMap<CreateLabelDTO, LabelEntity>();
        CreateMap<LabelEntity, LabelDTO>();
    }
}
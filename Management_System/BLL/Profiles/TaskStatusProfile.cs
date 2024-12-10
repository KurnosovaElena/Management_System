using BLL.DTO.CreateDTO;
using BLL.DTO;
using DAL.Entities;
using AutoMapper;

namespace BLL.Profiles;

public class TaskStatusProfile : Profile
{
    public TaskStatusProfile()
    {
        CreateMap<CreateTaskStatusDTO, TaskStatusEntity>();
        CreateMap<TaskStatusEntity, TaskStatusDTO>();
    }
}
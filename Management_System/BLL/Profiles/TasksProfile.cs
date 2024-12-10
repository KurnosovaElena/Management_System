using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using DAL.Entities;

namespace BLL.Profiles;

public class TasksProfile : Profile
{
    public TasksProfile()
    {
        CreateMap<CreateTasksDTO, TaskEntity>();
        CreateMap<TaskEntity, TasksDTO>();
    }
}
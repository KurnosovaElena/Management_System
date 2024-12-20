using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using DAL.Entities;

namespace BLL.Profiles;

public class ManagementSystemProfiles : Profile
{
    public ManagementSystemProfiles()
    {
        // Subtask mappings
        CreateMap<CreateSubtaskDto, SubtaskEntity>();
        CreateMap<SubtaskEntity, SubtaskDto>();

        // Board mappings
        CreateMap<CreateBoardDto, BoardEntity>();
        CreateMap<BoardEntity, BoardDto>();

        // Label mappings
        CreateMap<CreateLabelDto, LabelEntity>();
        CreateMap<LabelEntity, LabelDto>();

        // Task mappings
        CreateMap<CreateTasksDto, TaskEntity>();
        CreateMap<TaskEntity, TasksDto>();

        // TaskStatus mappings
        CreateMap<CreateTaskStatusDto, TaskStatusEntity>();
        CreateMap<TaskStatusEntity, TaskStatusDto>();

        // User mappings
        CreateMap<CreateUserDto, UserEntity>();
        CreateMap<UserEntity, UserDto>();

        // UserBoard mappings
        CreateMap<CreateUserBoardDto, UserBoardEntity>();
        CreateMap<UserBoardEntity, UserBoardDto>();

        // UserTask mappings
        CreateMap<CreateUserTaskDto, UserTaskEntity>();
        CreateMap<UserTaskEntity, UserTaskDto>();
    }
}
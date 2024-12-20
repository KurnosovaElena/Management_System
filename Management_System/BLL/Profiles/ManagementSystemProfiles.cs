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
        CreateMap<CreateSubtaskDTO, SubtaskEntity>();
        CreateMap<SubtaskEntity, SubtaskDTO>();

        // Board mappings
        CreateMap<CreateBoardDTO, BoardEntity>();
        CreateMap<BoardEntity, BoardDto>();

        // Label mappings
        CreateMap<CreateLabelDTO, LabelEntity>();
        CreateMap<LabelEntity, LabelDTO>();

        // Task mappings
        CreateMap<CreateTasksDTO, TaskEntity>();
        CreateMap<TaskEntity, TasksDTO>();

        // TaskStatus mappings
        CreateMap<CreateTaskStatusDTO, TaskStatusEntity>();
        CreateMap<TaskStatusEntity, TaskStatusDTO>();

        // User mappings
        CreateMap<CreateUserDTO, UserEntity>();
        CreateMap<UserEntity, UserDTO>();

        // UserBoard mappings
        CreateMap<CreateUserBoardDTO, UserBoardEntity>();
        CreateMap<UserBoardEntity, UserBoardDTO>();

        // UserTask mappings
        CreateMap<CreateUserTaskDTO, UserTaskEntity>();
        CreateMap<UserTaskEntity, UserTaskDTO>();
    }
}
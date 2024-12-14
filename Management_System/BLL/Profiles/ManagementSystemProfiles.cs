using AutoMapper;
using BLL.DTO.CreateDTO;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Profiles
{
    public class ManagementSystemProfiles : Profile
    {
        public ManagementSystemProfiles()
        {
            // Subtask mappings
            CreateMap<CreateSubtaskDTO, SubtaskEntity>();
            CreateMap<SubtaskEntity, SubtaskDTO>();

            // Board mappings
            CreateMap<CreateBoardDTO, BoardEntity>();
            CreateMap<BoardEntity, BoardDTO>();

            // Label mappings
            CreateMap<CreateLabelDTO, LabelEntity>();
            CreateMap<LabelEntity, LabelDTO>();

            // Task mappings
            CreateMap<CreateTasksDTO, TaskEntity>();
            CreateMap<TaskEntity, TasksDTO>();

            // TaskStatus mappings
            CreateMap<CreateTaskStatusDTO, TaskStatusEntity>();
            CreateMap<TaskStatusEntity, TaskStatusDTO>();
        }
    }
}

using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using DAL.Entities;

namespace BLL.Profiles;

public class BoardProfile : Profile 
{ 
    public BoardProfile() 
    { 
        CreateMap<CreateBoardDTO, BoardEntity>(); 
        CreateMap<BoardEntity, BoardDTO>(); 
    } 
}
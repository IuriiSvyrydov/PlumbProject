using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.TeamVM;

namespace ServiceLayer.Mapper;

public class TeamMapper :Profile
{
    public TeamMapper()
    {
        CreateMap<Team, TeamListVM>().ReverseMap();
        CreateMap<Team, AddTeamVM>().ReverseMap();
        CreateMap<Team, UpdateTeamVM>().ReverseMap();
    }
}
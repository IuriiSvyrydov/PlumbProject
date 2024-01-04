using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.HomePageVM;

namespace ServiceLayer.Mapper;

public class HomePageMapper: Profile
{
    public HomePageMapper()
    {
        CreateMap<HomePage, HomePageListVM>().ReverseMap();
        CreateMap<HomePage, HomePageAddVM>().ReverseMap();
        CreateMap<HomePage, HomePageUpdateVM>().ReverseMap();

    }
}
using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.AboutVM;

namespace ServiceLayer.Mapper;

public class AboutMapper: Profile
{
    public AboutMapper()
    {
        CreateMap<About, AboutListVM>().ReverseMap();
        CreateMap<About, AboutAddVM>().ReverseMap();
        CreateMap<About, AboutUpdateVM>().ReverseMap();
    }
}
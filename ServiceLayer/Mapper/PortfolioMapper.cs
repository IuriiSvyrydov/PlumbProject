using AutoMapper;
using EntityLayer.WevApplication.ViewModels.PortfolioVM;

namespace ServiceLayer.Mapper;

public class PortfolioMapper: Profile
{
    public PortfolioMapper()
    {
        CreateMap<Profile, PortfolioListVM>().ReverseMap();
        CreateMap<Profile, PortfolioAddVM>().ReverseMap();
        CreateMap<Profile, PortfolioAddVM>().ReverseMap();
    }
}
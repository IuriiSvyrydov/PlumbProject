using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.SocialMediaVM;

namespace ServiceLayer.Mapper;

public class SocialMediaMapper: Profile
{
    public SocialMediaMapper()
    {
        CreateMap<SocialMedia, SocialMediaListVM>().ReverseMap();
        CreateMap<SocialMedia, AddSocialMediaVM>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaVM>().ReverseMap();
    }
}
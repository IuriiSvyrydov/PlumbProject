using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.ServiceVM;

namespace ServiceLayer.Mapper;

public class ServiceMapper: Profile
{
    public ServiceMapper()
    {
        CreateMap<Service, AddServiceVM>().ReverseMap();
        CreateMap<Service, ServiceListVM>().ReverseMap();
        CreateMap<Service, UpdateServiceVM>().ReverseMap();
    }   
}
using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.ContactVM;

namespace ServiceLayer.Mapper;

public class ContactMapper : Profile
{
    public ContactMapper()
    {
        CreateMap<Contact, ContactListVM>().ReverseMap();
        CreateMap<Contact, ContactAddVM>().ReverseMap();
        CreateMap<Contact, ContactUpdateVM>().ReverseMap();
    }
}
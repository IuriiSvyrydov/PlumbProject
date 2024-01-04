using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.AboutVM;
using EntityLayer.WevApplication.ViewModels.CategoryVM;

namespace ServiceLayer.Mapper;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<Category, CategoryListVM>().ReverseMap();
        CreateMap<Category, CategoryAddVM>().ReverseMap();
        CreateMap<Category, CategoryUpdateVM>().ReverseMap();
    }
}
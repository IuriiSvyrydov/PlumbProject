using AutoMapper;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.TestimonialVM;

namespace ServiceLayer.Mapper;

public class TestimonialMapper : Profile
{
    public TestimonialMapper()
    {
        CreateMap<Testimonial, TestimonialListVM>().ReverseMap();
        CreateMap<Testimonial, AddTestimonialVM>().ReverseMap();
        CreateMap<Testimonial, UpdateTestimonialVM>().ReverseMap();
    }
}
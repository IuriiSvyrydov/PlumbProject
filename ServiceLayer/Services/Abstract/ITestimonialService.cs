using EntityLayer.WevApplication.ViewModels.SocialMediaVM;
using EntityLayer.WevApplication.ViewModels.TestimonialVM;

namespace ServiceLayer.Services.Abstract;

public interface ITestimonialService
{
    Task<List<TestimonialListVM>> GetAllListAsync();
    Task AddTestimonialList(AddTestimonialVM request);
    Task DeleteAsync(int id);
    Task<UpdateTestimonialVM> GetById(int id);
    Task UpdateTestimonialAsync(UpdateTestimonialVM request);

    //UpdateTestimonialAsync
}
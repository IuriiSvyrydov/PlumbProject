using EntityLayer.WevApplication.ViewModels.ServiceVM;
using EntityLayer.WevApplication.ViewModels.SocialMediaVM;

namespace ServiceLayer.Services.Abstract;

public interface ISocialMediaService
{
    Task<List<SocialMediaListVM>> GetAllListAsync();
    Task AddSocialMediaList(AddSocialMediaVM request);
    Task DeleteAsync(int id);
    Task<UpdateSocialMediaVM> GetById(int id);
    Task UpdateSocialMediaAsync(UpdateSocialMediaVM request);
}
using EntityLayer.WevApplication.ViewModels.HomePageVM;

namespace ServiceLayer.Services.Abstract;

public interface IHomePageService

{
    Task<List<HomePageListVM>> GetAllListAsync();
    Task AddHomePageList(HomePageAddVM request);
    Task DeleteAsync(int id);
    Task<HomePageUpdateVM> GetById(int id);
    Task UpdateHomePageAsync(HomePageUpdateVM request);
}   

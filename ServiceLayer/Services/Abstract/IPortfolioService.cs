using EntityLayer.WevApplication.ViewModels.HomePageVM;
using EntityLayer.WevApplication.ViewModels.PortfolioVM;

namespace ServiceLayer.Services.Abstract;

public interface IPortfolioService
{
    Task<List<PortfolioListVM>> GetAllListAsync();
    Task AddPortfolioList(PortfolioAddVM request);
    Task DeleteAsync(int id);
    Task<PortfolioUpdateVM> GetById(int id);
    Task UpdatePortfolioAsync(PortfolioUpdateVM request);
}
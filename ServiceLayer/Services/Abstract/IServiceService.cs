using EntityLayer.WevApplication.ViewModels.PortfolioVM;
using EntityLayer.WevApplication.ViewModels.ServiceVM;

namespace ServiceLayer.Services.Abstract;

public interface IServiceService
{
    Task<List<ServiceListVM>> GetAllListAsync();
    Task AddServiceList(AddServiceVM request);
    Task DeleteAsync(int id);
    Task<UpdateServiceVM> GetById(int id);
    Task UpdateServiceAsync(UpdateServiceVM request);
}

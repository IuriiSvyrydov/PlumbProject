using EntityLayer.WevApplication.ViewModels.AboutVM;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract;

public interface IAboutService
{
    Task<List<AboutListVM>> GetAllListAsync();
    Task AddAboutList(AboutAddVM request);
    Task DeleteAboutAsync(int id);
    Task<AboutUpdateVM> GetById(int id);
    Task UpdateAboutAsync(AboutUpdateVM request);

}
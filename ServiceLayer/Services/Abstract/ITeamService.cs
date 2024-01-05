using EntityLayer.WevApplication.ViewModels.SocialMediaVM;
using EntityLayer.WevApplication.ViewModels.TeamVM;

namespace ServiceLayer.Services.Abstract;

public interface ITeamService
{
    Task<List<TeamListVM>> GetAllListAsync();
    Task AddTeamList(AddTeamVM request);
    Task DeleteAsync(int id);
    Task<UpdateTeamVM> GetById(int id);
    Task UpdateTeamAsync(UpdateTeamVM request);
}
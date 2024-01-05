using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.TeamVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class TeamService:ITeamService
{
    #region private fields

    private readonly IGenericRepository<Team> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public TeamService(IGenericRepository<Team> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddTeamList(AddTeamVM request)
    {
        var team = _mapper.Map<Team>(request);
        await _repository.AddEntityAsync(team);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var team = await _repository.GetById(id);
        _repository.Delete(team);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<TeamListVM>> GetAllListAsync()
    {
        var teamList = await _repository.GetAllList().ProjectTo<TeamListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return teamList;
    }

    public async Task<UpdateTeamVM> GetById(int id)
    {
        var team = await _repository.Where(x => x.Id == id).ProjectTo<UpdateTeamVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return team;
    }

    public async Task UpdateTeamAsync(UpdateTeamVM request)
    {
        var team = _mapper.Map<Team>(request);
        _repository.Update(team);
        await _unitOfWork.CommitAsync();
    }

}
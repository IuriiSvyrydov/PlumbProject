using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.HomePageVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class HomePageService: IHomePageService
{
    #region private fields

    private readonly IGenericRepository<HomePage> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public HomePageService (IGenericRepository<HomePage> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddHomePageList(HomePageAddVM request)
    {
        var home = _mapper.Map<HomePage>(request);
        await _repository.AddEntityAsync(home);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var home = await _repository.GetById(id);
        _repository.Update(home);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<HomePageListVM>> GetAllListAsync()
    {
        var homeList = await _repository.GetAllList().ProjectTo<HomePageListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return homeList;
    }

    public async Task<HomePageUpdateVM> GetById(int id)
    {
        var home = await _repository.Where(x => x.Id == id).ProjectTo<HomePageUpdateVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return home;
    }

    public async Task UpdateHomePageAsync(HomePageUpdateVM request)
    {
        var home = _mapper.Map<HomePage>(request);
        _repository.Update(home);
        await _unitOfWork.CommitAsync();
    }
}
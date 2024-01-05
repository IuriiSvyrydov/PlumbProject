using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.AboutVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class AboutService: IAboutService
{
    #region private fields

    private readonly IGenericRepository<About> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    #endregion

    public AboutService( IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<About> repository)
    {
        
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<List<AboutListVM>> GetAllListAsync()
    {
        var aboutListVm = await _unitOfWork.GetGenericRepository<About>()
            .GetAllList()
            .ProjectTo<AboutListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return aboutListVm;

    }

    public async Task AddAboutList(AboutAddVM request)
    {
        var about = _mapper.Map<About>(request);
        await _repository.AddEntityAsync(about);
        await _unitOfWork.CommitAsync();


    }

    public async Task DeleteAboutAsync(int id)
    {
        var about = await _repository.GetById(id);
        _repository.Delete(about);
        await _unitOfWork.CommitAsync();
    }

    public async Task<AboutUpdateVM> GetById(int id)
    {
        var about = await _repository.Where(x => x.Id == id).ProjectTo<AboutUpdateVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return about;

    }

    public async Task UpdateAboutAsync(AboutUpdateVM request)
    {
        var about = _mapper.Map<About>(request);
        _repository.Update(about);
        await _unitOfWork.CommitAsync();
    }
}
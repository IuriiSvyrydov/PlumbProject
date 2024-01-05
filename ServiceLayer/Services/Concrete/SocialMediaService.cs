using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.SocialMediaVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class SocialMediaService:ISocialMediaService
{
    #region private fields

    private readonly IGenericRepository<SocialMedia> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public SocialMediaService(IGenericRepository<SocialMedia> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddSocialMediaList(AddSocialMediaVM request)
    {
        var social = _mapper.Map<SocialMedia>(request);
        await _repository.AddEntityAsync(social);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var social = await _repository.GetById(id);
        _repository.Delete(social);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<SocialMediaListVM>> GetAllListAsync()
    {
        var social = await _repository.GetAllList().ProjectTo<SocialMediaListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return social;
    }

    public async Task<UpdateSocialMediaVM> GetById(int id)
    {
        var social = await _repository.Where(x => x.Id == id).ProjectTo<UpdateSocialMediaVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return social;
    }

    public async Task UpdateSocialMediaAsync(UpdateSocialMediaVM request)
    {
        var social = _mapper.Map<SocialMedia>(request);
        _repository.Update(social);
        await _unitOfWork.CommitAsync();
    }

}
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.PortfolioVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class PortfolioService: IPortfolioService
{
    #region private fields

    private readonly IGenericRepository<Portfolio> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public PortfolioService(IGenericRepository<Portfolio> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddPortfolioList(PortfolioAddVM request)
    {
        var portfolio = _mapper.Map<Portfolio>(request);
        await _repository.AddEntityAsync(portfolio);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var portfolio = await _repository.GetById(id);
        _repository.Delete(portfolio);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<PortfolioListVM>> GetAllListAsync()
    {
        var portfolioListList = await _repository.GetAllList().ProjectTo<PortfolioListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return portfolioListList;
    }

    public async Task<PortfolioUpdateVM> GetById(int id)
    {
        var portfolio = await _repository.Where(x => x.Id == id).ProjectTo<PortfolioUpdateVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return portfolio;
    }

    public async Task UpdatePortfolioAsync(PortfolioUpdateVM request)
    {
        var portfolio = _mapper.Map<Portfolio>(request);
        _repository.Update(portfolio);
        await _unitOfWork.CommitAsync();
    }

}
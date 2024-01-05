using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.ServiceVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class ServiceService: IServiceService
{

    #region private fields

    private readonly IGenericRepository<Service> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public ServiceService(IGenericRepository<Service> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddServiceList(AddServiceVM request)
    {
        var service = _mapper.Map<Service>(request);
        await _repository.AddEntityAsync(service);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var service = await _repository.GetById(id);
        _repository.Delete(service);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<ServiceListVM>> GetAllListAsync()
    {
        var serviceList = await _repository.GetAllList().ProjectTo<ServiceListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return serviceList;
    }

    public async Task<UpdateServiceVM> GetById(int id)
    {
        var service = await _repository.Where(x => x.Id == id).ProjectTo<UpdateServiceVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return service;
    }

    public async Task UpdateServiceAsync(UpdateServiceVM request)
    {
        var service = _mapper.Map<Service>(request);
        _repository.Update(service);
        await _unitOfWork.CommitAsync();
    }

}
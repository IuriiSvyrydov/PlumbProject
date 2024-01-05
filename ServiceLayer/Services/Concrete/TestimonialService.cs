using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.TeamVM;
using EntityLayer.WevApplication.ViewModels.TestimonialVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class TestimonialService:ITestimonialService
{
    #region private fields

    private readonly IGenericRepository<Testimonial> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public TestimonialService(IGenericRepository<Testimonial> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddTestimonialList(AddTestimonialVM request)
    {
        var testimonial = _mapper.Map<Testimonial>(request);
        await _repository.AddEntityAsync(testimonial);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var testimonial = await _repository.GetById(id);
        _repository.Delete(testimonial);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<TestimonialListVM>> GetAllListAsync()
    {
        var testimonials = await _repository.GetAllList().ProjectTo<TestimonialListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return testimonials;
    }

    public async Task<UpdateTestimonialVM> GetById(int id)
    {
        var testimonial = await _repository.Where(x => x.Id == id).ProjectTo<UpdateTestimonialVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return testimonial;
    }

    public async Task UpdateTestimonialAsync(UpdateTestimonialVM request)
    {
        var testimonial = _mapper.Map<Testimonial>(request);
        _repository.Update(testimonial);
        await _unitOfWork.CommitAsync();
    }

}
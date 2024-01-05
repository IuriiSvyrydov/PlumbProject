using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.CategoryVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class CategoryService: ICategoryService
{
    #region private fields

    private readonly IGenericRepository<Category> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region CRUD operation

    public async Task<List<CategoryListVM>> GetAllListAsync()
    {
        var categoryList = await _repository.GetAllList().ProjectTo<CategoryListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return categoryList;
    }

    public async Task AddCategoryList(CategoryAddVM request)
    {
        var category = _mapper.Map<Category>(request);
        await _repository.AddEntityAsync(category);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var category = await _repository.GetById(id);
        _repository.Delete(category);
        await _unitOfWork.CommitAsync();
    }

    public async Task<CategoryUpdateVM> GetById(int id)
    {
        var category = await _repository.Where(x => x.Id == id).ProjectTo<CategoryUpdateVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return category;
    }

    public async Task UpdateCategoryAsync(CategoryUpdateVM request)
    {
        var category = _mapper.Map<Category>(request);
        _repository.Update(category);
        await _unitOfWork.CommitAsync();
    }
#endregion
}
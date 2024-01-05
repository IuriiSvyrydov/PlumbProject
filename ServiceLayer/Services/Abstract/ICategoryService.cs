using EntityLayer.WevApplication.ViewModels.AboutVM;
using EntityLayer.WevApplication.ViewModels.CategoryVM;

namespace ServiceLayer.Services.Abstract;

public interface ICategoryService
{
    Task<List<CategoryListVM>> GetAllListAsync();
    Task AddCategoryList(CategoryAddVM request);
    Task DeleteAsync(int id);
    Task<CategoryUpdateVM> GetById(int id);
    Task UpdateCategoryAsync(CategoryUpdateVM request);
}
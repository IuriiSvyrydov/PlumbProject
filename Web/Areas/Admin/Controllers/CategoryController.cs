using EntityLayer.WevApplication.ViewModels.AboutVM;
using EntityLayer.WevApplication.ViewModels.CategoryVM;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace Web.Areas.Admin.Controllers;

[Area("Admin")]
public class CategoryController : Controller
{


    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<IActionResult> GetCategoryList()
    {
        var aboutList = await _categoryService.GetAllListAsync();
        return View(aboutList);
    }

    [HttpGet]
    public async Task<IActionResult> AddCategory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddCategory(CategoryAddVM request)
    {
        await _categoryService.AddCategoryList(request);
        return RedirectToAction("GetCategoryList", "Category", new { Area = ("Admin") });
    }

    [HttpGet]
    public async Task<IActionResult> UpdateCategory(int id)
    {
        var category = await _categoryService.GetById(id);
        return View(category);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateAbout(CategoryUpdateVM request)
    {
        await _categoryService.UpdateCategoryAsync(request);
        return RedirectToAction("GetCategoryList", "Category", new { Area = ("Admin") });

    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAbout(int id)
    {
        await _categoryService.DeleteAsync(id);
        return RedirectToAction("GetCategoryList", "Category", new { Area = ("Admin") });
    }
}
        


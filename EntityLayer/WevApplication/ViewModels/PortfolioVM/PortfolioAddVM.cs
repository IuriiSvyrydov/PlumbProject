using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.CategoryVM;

namespace EntityLayer.WevApplication.ViewModels.PortfolioVM;

public class PortfolioAddVM
{
    public string Title { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public string FileType { get; set; } = null!;
    public int CategoryId { get; set; }
    public CategoryAddVM Category { get; set; } = null!;
}
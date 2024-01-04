using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.CategoryVM;

namespace EntityLayer.WevApplication.ViewModels.PortfolioVM;

public class PortfolioUpdateVM
{
    public int Id { get; set; }
    public string UpdateDate { get; set; } 
    public byte[] RowVersion { get; set; }

    public string Title { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public string FileType { get; set; } = null!;
    public int CategoryId { get; set; }
    public CategoryUpdateVM Category { get; set; } = null!;
}
    

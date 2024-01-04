namespace EntityLayer.WevApplication.ViewModels.CategoryVM;

public class CategoryListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }
  //  public byte[] RowVersion { get; set; } = null!;
  public string Name { get; set; } = null!;

}
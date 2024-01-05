namespace EntityLayer.WevApplication.ViewModels.ServiceVM;

public class ServiceListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }

    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Icon { get; set; } = null!;
}

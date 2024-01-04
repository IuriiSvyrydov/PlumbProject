namespace EntityLayer.WevApplication.ViewModels.HomePageVM;

public class HomePageListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }

    public string Header { get; set; }
    public string Description { get; set; }
    public string VideoLink { get; set; }
}
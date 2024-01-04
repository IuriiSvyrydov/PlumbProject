namespace EntityLayer.WevApplication.ViewModels.HomePageVM;

public class HomePageUpdateVM
{
    public int Id { get; set; }
    public string? UpdateDate { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public string Header { get; set; }
    public string Description { get; set; }
    public string VideoLink { get; set; }

}
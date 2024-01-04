namespace EntityLayer.WevApplication.ViewModels.TeamVM;

public class TeamListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }
    public string FullName { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public string FileType { get; set; } = null!;
    public string? Twitter { get; set; }
    public string? LinkedIn { get; set; }
    public string? FaceBook { get; set; }
    public string? Instagram { get; set; }

}
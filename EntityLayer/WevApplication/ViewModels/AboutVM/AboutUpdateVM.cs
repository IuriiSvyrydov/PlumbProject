using EntityLayer.WevApplication.ViewModels.SocialMediaVM;

namespace EntityLayer.WevApplication.ViewModels.AboutVM;

public class AboutUpdateVM
{
    public int Id{ get; set; }
    public string? UpdateDate { get; set; }
    public byte[] RowVersion{get; set; }

    public string Header { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Clients { get; set; }
    public int Projects { get; set; }
    public int HoursOfSupport { get; set; }
    public int HardWorkers { get; set; }
    public string FileName { get; set; } = null!;
    public string FileType { get; set; } = null!;
    public int SocialMediaId { get; set; }
    public UpdateSocialMediaVM SocialMedia { get; set; } = null!;

}
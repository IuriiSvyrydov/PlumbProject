using System.ComponentModel;
using EntityLayer.WevApplication.ViewModels.SocialMediaVM;
using Microsoft.AspNetCore.Http;

namespace EntityLayer.WevApplication.ViewModels.AboutVM;

public class AboutAddVM
{
    public string Header { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Clients { get; set; }
    public int Projects { get; set; }
    public int HoursOfSupport { get; set; }
    public int HardWorkers { get; set; }
    public string FileName { get; set; } = null!;
    public string FileType { get; set; } = null!;
    public int SocialMediaId { get; set; }
    public SocialMediaListVM SocialMedia { get; set; } = null!;
    [DisplayName("Photo")]
    public IFormFile Photo { get; set; } = null!;

}
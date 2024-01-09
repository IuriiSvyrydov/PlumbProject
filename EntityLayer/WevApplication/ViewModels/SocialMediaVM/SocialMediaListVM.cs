using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.AboutVM;

namespace EntityLayer.WevApplication.ViewModels.SocialMediaVM;

public class SocialMediaListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }
    public string? Twitter { get; set; }
    public string? LinkedIn { get; set; }
    public string? FaceBook { get; set; }
    public string? Instagram { get; set; }
    public AboutListVM About { get; set; }

}
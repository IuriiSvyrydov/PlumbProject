using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.AboutVM;

namespace EntityLayer.WevApplication.ViewModels.SocialMediaVM;

public class AddSocialMediaVM
{
    public string? Twitter { get; set; }
    public string? LinkedIn { get; set; }
    public string? FaceBook { get; set; }
    public string? Instagram { get; set; }
    public AboutAddVM About { get; set; }
}
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.AboutVM;

namespace EntityLayer.WevApplication.ViewModels.SocialMediaVM;

public class UpdateSocialMediaVM
{
    public int Id { get; set; }
    public string UpdateDate { get; set; }
    public byte[] RowVersion { get; set; }
    public string? Twitter { get; set; }
    public string? LinkedIn { get; set; }
    public string? FaceBook { get; set; }
    public string? Instagram { get; set; }
    public AboutUpdateVM About { get; set; }
}
    

namespace EntityLayer.WevApplication.ViewModels.SocialMediaVM;

public class SocialMediaListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }

}
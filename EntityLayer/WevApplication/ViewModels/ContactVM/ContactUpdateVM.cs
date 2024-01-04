namespace EntityLayer.WevApplication.ViewModels.ContactVM;

public class ContactUpdateVM
{
    public int Id { get; set; }
   // public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }
    public byte[] RowVersion { get; set; }
    public string Location { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Call { get; set; } = null!;
    public string Map { get; set; } = null!;
}

namespace EntityLayer.WevApplication.ViewModels.ServiceVM;

public class UpdateServiceVM
{
    public int Id { get; set; }
    public string UpdateDate { get; set; }
    public byte[] RowVersion { get; set; }

    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Icon { get; set; } = null!;

}

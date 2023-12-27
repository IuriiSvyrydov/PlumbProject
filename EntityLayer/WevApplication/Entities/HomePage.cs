using CoreLayer.BaseEntities;

namespace EntityLayer.WevApplication.Entities;

public class HomePage : BaseEntity
{
    
    public string Header { get; set; }
    public string Description { get; set; }
    public string VideoLink { get; set; }

}
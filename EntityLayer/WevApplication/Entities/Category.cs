using CoreLayer.BaseEntities;

namespace EntityLayer.WevApplication.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Portfolio> Portfolios { get; set; } = null!;
}
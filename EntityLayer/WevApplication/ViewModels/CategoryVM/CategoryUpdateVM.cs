﻿namespace EntityLayer.WevApplication.ViewModels.CategoryVM;

public class CategoryUpdateVM
{
    public int Id { get; set; }
    
    public string? UpdateDate { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public string Name { get; set; } = null!;

}
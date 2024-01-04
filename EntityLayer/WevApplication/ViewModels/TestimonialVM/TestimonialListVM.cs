﻿namespace EntityLayer.WevApplication.ViewModels.TestimonialVM;

public class TestimonialListVM
{
    public int Id { get; set; }
    public string CreateDate { get; set; } = DateTime.Now.ToString("d");
    public string? UpdateDate { get; set; }
    public string Comment { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public string FileType { get; set; } = null!;


}
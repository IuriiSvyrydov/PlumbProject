using System.Reflection;
using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context;

public class AppDbContext :DbContext
{
    public AppDbContext()
    {

    }

    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {
        
    }

   
    public DbSet<HomePage> HomePages { get; set; }
    public DbSet<About> AboutUs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> ContactUs { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
         base.OnModelCreating(modelBuilder);
    }
}
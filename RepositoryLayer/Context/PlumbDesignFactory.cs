using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RepositoryLayer.Context;

public class PlumbDesignFactory: IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=REVISION-PC;Database=PlumbDb;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=true;");

        return new AppDbContext(optionsBuilder.Options);
    }
}
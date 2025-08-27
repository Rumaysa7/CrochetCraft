using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Add your custom DbSets here for future crochet-related models
    // public DbSet<Product> Products { get; set; }
    // public DbSet<Tutorial> Tutorials { get; set; }
}

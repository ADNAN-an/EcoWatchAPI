using Microsoft.EntityFrameworkCore;

namespace EcoWatchAPI.Models
{ 
public class BlogPostContext : DbContext
{
    public BlogPostContext(DbContextOptions<BlogPostContext> options)
        : base(options)
    {
    }

    public DbSet<BlogPost> BlogPost { get; set; } = null!;
}
}

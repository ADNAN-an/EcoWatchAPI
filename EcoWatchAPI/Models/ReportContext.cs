using Microsoft.EntityFrameworkCore;

namespace EcoWatchAPI.Models
{
    public class ReportContext : DbContext
    {
        public ReportContext(DbContextOptions<ReportContext> options)
            : base(options)
        {
        }

        public DbSet<Report> BlogPost { get; set; } = null!;
    }
}

using Microsoft.EntityFrameworkCore;
using assetsbackend.Domain.Entity;

namespace assetsbackend.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
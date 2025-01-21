using MahanApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MahanApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
    }
}

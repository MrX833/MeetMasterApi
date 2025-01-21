using MeetMasterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetMasterApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
    }
}

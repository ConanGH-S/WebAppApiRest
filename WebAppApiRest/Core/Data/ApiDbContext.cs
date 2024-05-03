using Microsoft.EntityFrameworkCore;
using WebAppApiRest.Core.Models;

namespace WebAppApiRest.Core.Data
{
    public class ApiDbContext(DbContextOptions<ApiDbContext> options): DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}

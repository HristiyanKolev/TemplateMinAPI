using Microsoft.EntityFrameworkCore;
using TemplateMinAPI.Models;

namespace TemplateMinAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Command> Commands=> Set<Command>();
    }
}
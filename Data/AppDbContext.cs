using BlazorCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class AppDbContext : DbContext { 
        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; } = null!;
    }
}

using Artisanaux.Service.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Artisanaux.Service.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product>? Products { get; set; }
    }
}

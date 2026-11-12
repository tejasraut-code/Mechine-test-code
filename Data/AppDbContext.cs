using Mechine_Test_Code.Models.Domain_Models;
using Microsoft.EntityFrameworkCore;

namespace Mechine_Test_Code.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<ServiceModel> Services { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}

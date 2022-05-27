using Kentaka_Webshop.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kentaka_Webshop.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public virtual DbSet<TestProductEntity> TestProducts { get; set; } = null!;
        public virtual DbSet<CategoryEntity> Categories { get; set; }
        public virtual DbSet<ContactUsMessageEntity> ContactMessages { get; set; }

    }
}

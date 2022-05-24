using Kentaka_Webshop.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kentaka_Webshop.Data
{
    public class SqlDbContext :   IdentityDbContext
    {
        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public virtual DbSet<TestProductEntity> TestProducts { get; set; } = null!;
    }
}

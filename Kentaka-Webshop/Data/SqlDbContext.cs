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
    }
}

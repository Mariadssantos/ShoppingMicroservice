using Microsoft.EntityFrameworkCore;

namespace Shopping.ProductApi.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){ }
    }
}

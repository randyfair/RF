using Microsoft.EntityFrameworkCore;
using RF.API.Models;

namespace RF.API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}
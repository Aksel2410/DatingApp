using dating_app.API.Models;
using Microsoft.EntityFrameworkCore;

namespace dating_app.API.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
    }
}
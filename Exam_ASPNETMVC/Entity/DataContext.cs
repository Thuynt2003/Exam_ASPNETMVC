using Microsoft.EntityFrameworkCore;

namespace Exam_ASPNETMVC.Entity
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contacts> Contacts { get; set; }
    }
}

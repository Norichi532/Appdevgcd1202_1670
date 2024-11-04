using Appweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Appweb.Data
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}

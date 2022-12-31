using Microsoft.EntityFrameworkCore;

namespace MyTestingMVC.Models
{
    public class RepositoryContext: DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext>)
        public RepositoryContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Furniture> Furniture { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ocl_msds
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }



    }
}

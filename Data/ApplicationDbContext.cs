using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOption<ApplicationDbContext> options):base(options)
        {
               
        }
    }
}
 
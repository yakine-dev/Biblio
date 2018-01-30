using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Biblio.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Livre> Livres { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // ¡ESTA ES LA CLAVE!
using Microsoft.AspNetCore.Identity; // Para IdentityUser
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}



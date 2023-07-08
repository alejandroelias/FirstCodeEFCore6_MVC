using FirstCodeEFCore6_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstCodeEFCore6_MVC
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Proveedores> Proveedores { get; set; }
    }

}

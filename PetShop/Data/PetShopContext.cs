using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }

    
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empregados> Empregados { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Animais> Animais { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
            .HasKey(vl => new { vl.Id});
        }
    }
}
